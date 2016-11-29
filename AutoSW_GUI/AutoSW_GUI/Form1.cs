using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using EASendMail;
using System.Data.SqlClient;
using System.Collections;

using MyMail = System.Net.Mail; //MyMail reference name used to avoid ambigousity beetween EASendMail and System.Net.Mail
using System.Threading;

namespace WindowsFormsApplication1{

    public partial class Form1 : Form
    {
        int idPersona = 0;
        bool automaticModeState;  // True for Automatic Mode ON, False for Automatic Mode OFF
        //SqlDataReader reader, rdr;

        public Form1()
        {
            InitializeComponent();         
        }

 //  METHODS USED FOR THE ENTIRE CODE
        public void disableUpdateBDButtons()
        {
            buttonSettingTabSave.Enabled = false;
            buttonSearchEditModificate.Enabled = false;
            buttonSearchEditEliminate.Enabled = false;
            buttonAddSave.Enabled = false;
        }
        public void enableUpdateBDButtons()
        {
            buttonSettingTabSave.Enabled = true;
            buttonSearchEditModificate.Enabled = true;
            buttonSearchEditEliminate.Enabled = true;
            buttonAddSave.Enabled = true;
        }
        public bool ValidString(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            foreach (char c in input)
            {
                if (!Char.IsLetter(c) && !Char.IsSeparator(c))
                    return false;
            }
            return true;
        }
        public bool smtpCheck(string emailaddress)
        {
            SmtpMail oMail = new SmtpMail("TryIt");
            SmtpClient oSmtp = new SmtpClient();

            // Set sender email address, please change it to yours
            oMail.From = "poncenavarroluisfelipe@gmail.com";

            // Set recipient email address, please change it to yours
            oMail.To = emailaddress;

            // Do not set SMTP server address
            SmtpServer oServer = new SmtpServer("");

            if (string.IsNullOrEmpty(emailaddress)) return false;
            try
            {
                //MailAddress m = new MailAddress(emailaddress);
                oSmtp.TestRecipients(oServer, oMail);
                return true;
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message);
                return false;
            }
        }
        public bool ValidMail(string emailaddress)
        {
            if (checkBoxSearchnEditVerifyEmail.Checked && textBoxSearchEditEmail.TextLength > 1)
            {
                return smtpCheck(emailaddress);
            }

            if (checkBoxAddVerifyEmail.Checked && textBoxAddEmail.TextLength > 1)
            {
                return smtpCheck(emailaddress);
            }

            else
            {
                string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(emailaddress)) return true;
                else return false;
            }
        }
        public void UpdateContactBD(int updateType, string name = null, string firstLN = null, string secondLN = null, string email = null)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Persist Security Info=False;Integrated Security=true;Initial Catalog=AutoSW;server=(local)");
                SqlCommand cmd = new SqlCommand();
                SqlParameter parameter = new SqlParameter();

                cmd.Connection = conn;

                if (updateType == 1)
                {
                    cmd.CommandText = "InsertNewContact";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 50);
                    cmd.Parameters["@name"].Value = name;

                    cmd.Parameters.Add("@firstLastName", SqlDbType.VarChar, 50);
                    cmd.Parameters["@firstLastName"].Value = firstLN;

                    cmd.Parameters.Add("@secondLastName", SqlDbType.VarChar, 50);
                    cmd.Parameters["@secondLastName"].Value = secondLN;

                    cmd.Parameters.Add("@email", SqlDbType.VarChar, 50);
                    cmd.Parameters["@email"].Value = email;
                }

                if (updateType == 2)
                {
                    cmd.CommandText = "UpdateContact";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 50);
                    cmd.Parameters["@name"].Value = name;

                    cmd.Parameters.Add("@firstLastName", SqlDbType.VarChar, 50);
                    cmd.Parameters["@firstLastName"].Value = firstLN;

                    cmd.Parameters.Add("@secondLastName", SqlDbType.VarChar, 50);
                    cmd.Parameters["@secondLastName"].Value = secondLN;

                    cmd.Parameters.Add("@email", SqlDbType.VarChar, 50);
                    cmd.Parameters["@email"].Value = email;

                    cmd.Parameters.Add("@IdPersona", SqlDbType.Int);
                    cmd.Parameters["@IdPersona"].Value = idPersona;

                }

                if (updateType == 3)
                {
                    cmd.CommandText = "DeleteContact";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@IdPersona", SqlDbType.Int);
                    cmd.Parameters["@IdPersona"].Value = idPersona;
                }

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { conn.Close(); idPersona = 0; }

        }
            //Launches an event or function whether certain tab is selected
        private void Tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (wholeTabs.SelectedTab.Name == "settingTab")
            {
                refreshConfigCalendarTabInfo();
            }
            if (wholeTabs.SelectedTab.Name == "autoEmailTab")
            {
                
                refreshConfigCalendarTabInfo();
                if (automaticModeState)
                    checkBoxAutoSendEmail.Text = "Automatic Mode ON";
                else
                    checkBoxAutoSendEmail.Text = "Automatic Mode OFF";

                ShowHistoryMailing();
            }
        }

 // TAB FOR ADD USER CODE
        private void buttonAddSave_Click(object sender, EventArgs e)
        {
            string name = textBoxAddName.Text;
            string firstLN = textBoxAddFirstLastName.Text;
            string secondLN = textBoxAddSecondLastName.Text;
            string email = textBoxAddEmail.Text;
            if (ValidString(name) && ValidString(firstLN) && ValidString(secondLN) && ValidMail(email))
            {
                UpdateContactBD(1, name, firstLN, secondLN, email);
                textBoxAddName.Clear();
                textBoxAddFirstLastName.Clear();
                textBoxAddSecondLastName.Clear();
                textBoxAddEmail.Clear();
                MessageBox.Show("Datos Guardados!");
            }
            else
                MessageBox.Show("Datos no validos para ser guardados");
        }
        private void buttonAddCancel_Click(object sender, EventArgs e)
        {
            textBoxAddName.Clear();
            textBoxAddFirstLastName.Clear();
            textBoxAddSecondLastName.Clear();
            textBoxAddEmail.Clear();
        }

 // TAB FOR SEARCH AND EDIT CODE
        private void textBoxSearchEditName_Click(object sender, EventArgs e)
        {
            if (!ValidString(textBoxSearchEditName.Text))
            {
                textBoxSearchEditName.Clear();
                textBoxSearchEditSecondLastName.Text = "*Second Lastname";
                textBoxSearchEditFirstLastName.Text = "*First Lastname";
                textBoxSearchEditEmail.Text = "*E-mail";
            }
        }
        private void textBoxSearchEditEmail_Click(object sender, EventArgs e)
        {
            if (!ValidMail(textBoxSearchEditEmail.Text))
            {
                textBoxSearchEditEmail.Clear();
                textBoxSearchEditSecondLastName.Text = "*Second Lastname";
                textBoxSearchEditFirstLastName.Text = "*First Lastname";
                textBoxSearchEditName.Text = "*Name";
            }
        }
        private void textBoxSearchEditFirstLastName_Click(object sender, EventArgs e)
        {
            if (!ValidString(textBoxSearchEditFirstLastName.Text))
            {
                textBoxSearchEditFirstLastName.Clear();
                textBoxSearchEditSecondLastName.Text = "*Second Lastname";
                textBoxSearchEditEmail.Text = "*E-mail";
                textBoxSearchEditName.Text = "*Name";
            }
        }
        private void textBoxSearchEditSecondLastName_Click(object sender, EventArgs e)
        {
            if (!ValidString(textBoxSearchEditSecondLastName.Text))
            {
                textBoxSearchEditSecondLastName.Clear();
                textBoxSearchEditFirstLastName.Text = "*First Lastname";
                textBoxSearchEditEmail.Text = "*E-mail";
                textBoxSearchEditName.Text = "*Name";
            }
        }
        private void buttonSearchEditModificate_Click(object sender, EventArgs e)
        {
            string name = textBoxSearchEditName.Text;
            string firstLN = textBoxSearchEditFirstLastName.Text;
            string secondLN = textBoxSearchEditSecondLastName.Text;
            string email = textBoxSearchEditEmail.Text;

            if (ValidString(name) && ValidString(firstLN) && ValidString(secondLN) && ValidMail(email))
            {
                UpdateContactBD(2, name, firstLN, secondLN, email);
                textBoxSearchEditName.Clear();
                textBoxSearchEditFirstLastName.Clear();
                textBoxSearchEditSecondLastName.Clear();
                textBoxSearchEditEmail.Clear();
                MessageBox.Show("Campos Guardados!");
                dataGridViewContacts.Visible = false;
            }
            else
            {
                MessageBox.Show("Datos no validos para ser guardados");
            }
        }
        private void buttonSearchEditEliminate_Click(object sender, EventArgs e)
        {
            string name = textBoxSearchEditName.Text;
            string firstLN = textBoxSearchEditFirstLastName.Text;
            string secondLN = textBoxSearchEditSecondLastName.Text;
            string email = textBoxSearchEditEmail.Text;

            if (ValidString(name) && ValidString(firstLN) && ValidString(secondLN) && ValidMail(email))
            {
                UpdateContactBD(3);
                textBoxSearchEditName.Clear();
                textBoxSearchEditFirstLastName.Clear();
                textBoxSearchEditSecondLastName.Clear();
                textBoxSearchEditEmail.Clear();
                MessageBox.Show("Eliminado!");
                dataGridViewContacts.Visible = false;
            }
            else
            {
                MessageBox.Show("Selecciona un contacto para poder eliminarlo!, si ya lo haz seleccionado entonces no lo alteres!");
            }

        }
            //Search fuction
        private void buttonSearchEditLookFor_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Persist Security Info=False;Integrated Security=true;Initial Catalog=AutoSW;server=(local)");
                SqlCommand cmd = new SqlCommand();
                SqlParameter parameter = new SqlParameter();

                cmd.Connection = conn;

                if (ValidString(textBoxSearchEditName.Text))
                {
                    cmd.CommandText = "ShowAllContactsNameCoincidence";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@contactName", SqlDbType.VarChar, 50);
                    cmd.Parameters["@contactName"].Value = textBoxSearchEditName.Text;
                }
                else if (ValidString(textBoxSearchEditFirstLastName.Text))
                {
                    cmd.CommandText = "ShowAllContactsAPCoincidence";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@contactAP", SqlDbType.VarChar, 50);
                    cmd.Parameters["@contactAP"].Value = textBoxSearchEditFirstLastName.Text;
                }
                else if (ValidString(textBoxSearchEditEmail.Text))
                {
                    cmd.CommandText = "ShowAllContactsEmailCoincidence";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@theEmail", SqlDbType.VarChar, 50);
                    cmd.Parameters["@theEmail"].Value = textBoxSearchEditEmail.Text;
                }
                else if (ValidString(textBoxSearchEditSecondLastName.Text))
                {
                    cmd.CommandText = "ShowAllContactsAMCoincidence";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@contactAM", SqlDbType.VarChar, 50);
                    cmd.Parameters["@contactAM"].Value = textBoxSearchEditSecondLastName.Text;
                }
                else
                {
                    cmd.CommandText = "ShowAllContactsAToZ";
                    cmd.CommandType = CommandType.StoredProcedure;
                }

                using (SqlDataAdapter da = new SqlDataAdapter(cmd)){  //Filling data grid with the search stored procedure
                    conn.Open();
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0 && dt != null){               
                        dataGridViewContacts.Visible = true;
                        dataGridViewContacts.DataSource = dt;
                    }
                    else
                        dataGridViewContacts.Visible = false;       
                }
            }
            catch (Exception) { throw; }
            finally{conn.Close();}
            textBoxSearchEditSecondLastName.Text = "*Second Lastname";
            textBoxSearchEditFirstLastName.Text = "*First Lastname";
            textBoxSearchEditEmail.Text = "*E-mail";
            textBoxSearchEditName.Text = "*Name";
        }
            //Grid table code FOR SEARCH AND EDIT TAB
        private void dataGridViewContacts_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewContacts.SelectedCells.Count > 0 && dataGridViewContacts.RowCount > 1)
            {
                int selectedrowindex = dataGridViewContacts.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridViewContacts.Rows[selectedrowindex];

                textBoxSearchEditEmail.Text = Convert.ToString(selectedRow.Cells["Email"].Value);
                textBoxSearchEditName.Text = Convert.ToString(selectedRow.Cells["Nombre"].Value);
                textBoxSearchEditFirstLastName.Text = Convert.ToString(selectedRow.Cells["ApellidoPaterno"].Value);
                textBoxSearchEditSecondLastName.Text = Convert.ToString(selectedRow.Cells["ApellidoMaterno"].Value);
                idPersona = Convert.ToInt32(selectedRow.Cells["IdPersona"].Value);  
            }
        }
        
 //  TAB FOR CONFIGURATION AND CALENDAR TAB
        private void refreshConfigCalendarTabInfo()
        {
            SqlConnection conn = null;
            try
            {
                //Openning SQL and executing Storage procedure to get all the contacts info
                conn = new SqlConnection("Persist Security Info=False;Integrated Security=true;Initial Catalog=AutoSW;server=(local)");
                SqlCommand cmd = new SqlCommand();
                SqlParameter parameter = new SqlParameter();
                cmd.Connection = conn;
                cmd.CommandText = "ShowLatestConfig";
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader(); //CommandBehavior.CloseConnection

                while (reader.Read())
                {
                    if (reader["Modalidad"].Equals(false))
                    {
                        listBoxSettingTabMode.SelectedIndex = 0;
                        automaticModeState = false;
                    }
                    if (reader["Modalidad"].Equals(true))
                    {
                        listBoxSettingTabMode.SelectedIndex = 1;
                        automaticModeState = true;
                    }
                    textBoxSettingTabPeriodicity.Text = reader["Periodicidad"].ToString();
                    textBoxSettingTabLastConfigDate.Text = reader["FechaConfiguracion"].ToString();
                }
            }
            catch (Exception) { throw; }
            finally { conn.Close(); }
        }
        private void InsertNewConfigCalendarTabInfo(int periodicity)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Persist Security Info=False;Integrated Security=true;Initial Catalog=AutoSW;server=(local)");
                SqlCommand cmd = new SqlCommand();
                SqlParameter parameter = new SqlParameter();

                cmd.Connection = conn;

                cmd.CommandText = "InsertNewConfig";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@modalidad", SqlDbType.Bit);
                cmd.Parameters["@modalidad"].Value = listBoxSettingTabMode.SelectedIndex;

                cmd.Parameters.Add("@periodicidad", SqlDbType.Int);
                cmd.Parameters["@periodicidad"].Value = periodicity; 

                cmd.Parameters.Add("@idPersona", SqlDbType.Int);
                cmd.Parameters["@idPersona"].Value = 2;  // <-- Este valor sera reemplazado posteriormente por el IdPersona del Usuario "Loggeado"

                cmd.Parameters.Add("@idUsuario", SqlDbType.Int);
                cmd.Parameters["@idUsuario"].Value = 2; // <-- Este valor sera reemplazado posteriormente por el IdUsuario "Loggeado"

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally { conn.Close();}
        }
        private void buttonSettingTabSave_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (int.TryParse(textBoxSettingTabPeriodicity.Text, out parsedValue))
            {
                //Console.WriteLine(listBoxSettingTabMode.SelectedIndex);
                //Console.WriteLine(parsedValue);
                if (parsedValue > 365 || parsedValue < 1)
                {
                    MessageBox.Show("Periodicidad invalida o mayor a un año");
                    refreshConfigCalendarTabInfo();
                }
                else
                {
                    InsertNewConfigCalendarTabInfo(parsedValue);
                    refreshConfigCalendarTabInfo();
                    MessageBox.Show("Configuracion Guardada Exitosamente!");
                }
            }
            else
            {
                MessageBox.Show("Datos no validos para ser guardados");
                refreshConfigCalendarTabInfo();
            }
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //monthCalendarSettingTab.SelectionStart
            SelectionRange sr = monthCalendarSettingTab.SelectionRange;
            int numberOfDays = sr.End.Subtract(sr.Start).Days + 1;
            textBoxSettingTabPeriodicity.Text = Convert.ToString(numberOfDays);
        }
 //  TAB FOR AUTOMATED EMAIL
        private void ShowHistoryMailing()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Persist Security Info=False;Integrated Security=true;Initial Catalog=AutoSW;server=(local)");
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "ShowAllMailingInfo";
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {  //Filling data grid withShowAllMailingInfo stored procedure
                    con.Open();
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0 && dt != null)
                    {
                        dataGridViewAutoMailTab.Visible = true;
                        dataGridViewAutoMailTab.DataSource = dt;
                    }
                    else
                        dataGridViewAutoMailTab.Visible = false;
                }
            }
            catch (Exception) { throw; }
            finally { con.Close();}
        }
        private void InsertNewMailingingInfo(int CantidadContactos, int CantidadArchivos, float TamanioArchivos)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Persist Security Info=False;Integrated Security=true;Initial Catalog=AutoSW;server=(local)");
                SqlCommand cmd = new SqlCommand();
                SqlParameter parameter = new SqlParameter();

                cmd.Connection = conn;

                cmd.CommandText = "InsertNewMailingInfo";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CantidadContactos", SqlDbType.Int);
                cmd.Parameters["@CantidadContactos"].Value = CantidadContactos;

                cmd.Parameters.Add("@CantidadArchivos", SqlDbType.Int);
                cmd.Parameters["@CantidadArchivos"].Value = CantidadArchivos;

                cmd.Parameters.Add("@TamanioArchivos", SqlDbType.Float);
                cmd.Parameters["@TamanioArchivos"].Value = TamanioArchivos;  

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; } // Here I dont close connection because this method is called from another that closes BD connection
        }
        private bool validatingFilesToSend(List<string> filesListPath, out int filesQuantity, out float sizeByte)
        {
            sizeByte = 0;
            filesQuantity = 0;
            System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo("C:\\AutoSW_PublicityFiles");
            if (dirInfo.Exists == true)
            {
                dirInfo.Refresh(); //Ensuring the latest changes of the folder
                System.IO.FileInfo[] fileNames = dirInfo.GetFiles("*.jpg");
                int numOfFilesAllowed = 0;
                if (automaticModeState)
                    numOfFilesAllowed = 3; //max number of files allowed when automatic mode is ON
                else
                    numOfFilesAllowed = 2147483647;  // max number of files allowed for 32-bit integer XD When Automatic is OFF

                foreach (System.IO.FileInfo fi in fileNames)
                {
                    if (sizeByte < 25000000 && filesQuantity < numOfFilesAllowed)
                    {
                        //Console.WriteLine("\nName: {0}, File´s creation time: {1}, Size: {2}", fi.Name, fi.CreationTime, fi.Length);
                        sizeByte += fi.Length;
                        filesQuantity++;
                        filesListPath.Add(fi.Name);
                    }
                    else return false;
                }
                if (filesQuantity <= 0) return false;
                sizeByte /= 1024;
                sizeByte /= 1024;
                //Console.WriteLine("\nTOTAL Files: {0}, Size of those files: {1}MB \n\n\n", filesQuantity, sizeByte); 
                return true;
            }
            else return false;
        }
        private void checkBoxAutoSendEmail_CheckedChanged(object sender, EventArgs e)
        {
            string path = "C:\\AutoSW_PublicityFiles\\";
            List<string> filesPath = new List<string>(); //List of file names to send
            SqlConnection conn = null;
            int contactsQuantity = 0, filesQuantity = 0, startTime, elapsedTime;
            float totalMBSize = 0;
                      
            try
            {
                //disableUpdateBDButtons();
                if (validatingFilesToSend(filesPath, out filesQuantity, out totalMBSize))
                {
                    Thread mailingThread = new Thread(delegate()
                    {
                        Console.WriteLine("Starting Sending emails Thread ");
                        startTime = Environment.TickCount; // start time of this Send Email Proccess
 
                        conn = new SqlConnection("Persist Security Info=False;Integrated Security=true;Initial Catalog=AutoSW;server=(local)");
                        SqlCommand cmd = new SqlCommand();
                        SqlParameter parameter = new SqlParameter();
                        cmd.Connection = conn;
                        cmd.CommandText = "ShowAllContactsAToZ";
                        cmd.CommandType = CommandType.StoredProcedure;
                                              
                        //Email code required started from here
                        System.Net.Mail.Attachment attachment;
                        MyMail.SmtpClient smtp = new MyMail.SmtpClient();
                        smtp.Host = "smtp.gmail.com";
                        MyMail.MailAddress fromAddress = new MyMail.MailAddress("poncenavarroluisfelipe@gmail.com");

                        // set up the Gmail server
                        smtp.UseDefaultCredentials = false;
                        smtp.Port = 587;
                        smtp.EnableSsl = true;
                        smtp.DeliveryMethod = MyMail.SmtpDeliveryMethod.Network;
                        smtp.Credentials = new System.Net.NetworkCredential("poncenavarroluisfelipe@gmail.com", "psw");
                        smtp.DeliveryMethod = MyMail.SmtpDeliveryMethod.Network;
                        
                        conn.Open();
                        SqlDataReader rdr = cmd.ExecuteReader(); //CommandBehavior.CloseConnection
                        while (rdr.Read())
                        {                          
                            // draft the email
                            MyMail.MailMessage email = new MyMail.MailMessage();
                            email.From = fromAddress;
                            email.Subject = "Nites !! :)";
                            email.Body = "Dear " + rdr["Nombre"].ToString() + " " + rdr["ApellidoPaterno"].ToString() + ": \n\nCon esta me despido";
                            email.To.Add(rdr["Email"].ToString());
                            filesPath.ForEach(delegate(string name)
                            {
                                attachment = new System.Net.Mail.Attachment(path + name);
                                email.Attachments.Add(attachment);
                                //Console.WriteLine(path + name);
                            });
                            smtp.Send(email); 

                            //Console.WriteLine("\nDEAR " + rdr["Nombre"].ToString() + " " + rdr["ApellidoPaterno"].ToString() + ": \n\nSee our Latest Offers We got for you attached");
                            //Console.WriteLine("To: " + rdr["Email"].ToString() + "\n");
                            contactsQuantity++;
                            Console.WriteLine("Correo enviado no. " + contactsQuantity);
                        }
                        conn.Close();

                        InsertNewMailingingInfo(contactsQuantity, filesQuantity, totalMBSize); //Inserting Mailing Info to BD

                        elapsedTime = Environment.TickCount - startTime; // end time of this Send Email Proccess
                        var timeSpan = TimeSpan.FromMilliseconds(elapsedTime);
                        MessageBox.Show("E-mail Sended to " + contactsQuantity + " Contacts with " + filesQuantity + " files and Total Size of "
                        + totalMBSize + "MB\n Time Elapsed for this operation was: " + timeSpan.TotalMinutes + " minutos");
                    });

                    mailingThread.Start();          
                    MessageBox.Show("Sending emails . . . . \n It could take a while depending on contacts quantity");
                    enableUpdateBDButtons();
                }
                else
                {
                    MessageBox.Show("No hay archivos o cantidad de archivos mayor a 3, o el tamaño total de los archivos mayor a 25MB");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al enviar correo no. " + contactsQuantity + "\nExcepcion: "+ ex);
                conn.Close();
            }
        }

    }
}
