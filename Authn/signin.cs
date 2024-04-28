using Green_house_chikale.Authn;
using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Green_house_chikale
{
    public partial class Signin : UserControl
    {
        
        public Signin()
        {
            InitializeComponent();
            
        }
        Database db = new Database();
        public static string Sessions;
        private int attemptCount = 0;
        private DateTime lockTime;

        private void Signin_Load(object sender, EventArgs e)
        { 
            string filePath = @"LoginAttempts.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length > 0)
                {
                    attemptCount = int.Parse(lines[0]);
                    lockTime = DateTime.Parse(lines[1]);
                }
            }
        }
    private async void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();

            try
            {

                db.OpenConnection();
                command.Connection = db.GetConnection;
                command.CommandText = "SELECT * FROM users WHERE Username = '" + Email.Text + "' and password = '" + Password.Text + "'";
                MySqlDataReader rd = command.ExecuteReader();
                int count = 0;
                while (rd.Read())
                {
                    count = count + 1;


                }
                if (count == 1)
                {
                    Sessions = Email.Text;
                    // Authentication successful, hide the signin form and show the dashboard
                    this.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                   

                }
                else if (Email.Text == "" || Password.Text == "")
                {
                    MessageBox.Show("Unable to Login.. the text fields cannot be left empty", "Error on Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Unable to Login.. Please check your login credentials", "Error on Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                using (StreamWriter sw = new StreamWriter("login_attempts.txt", true))
                {
                    sw.WriteLine(DateTime.Now + " - " + Email.Text + " - " + (count == 1 ? "Success" : "Failed"));
                }

                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            
                
        }

      
    }
}
 
