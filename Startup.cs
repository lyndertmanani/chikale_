using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using Green_house_chikale.Authn;
using System.Data;

namespace Green_house_chikale
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        private async void Startup_Load(object sender, EventArgs e)
        {
            await Task.Run(() => CheckConnectionStatus());
        }

        private async Task CheckConnectionStatus()
        {
            bool isInternetAvailable = await IsInternetAvailableAsync();
            bool isMySQLConnected = await ConnectToMySQL();

            if (!isInternetAvailable)
            {
                MessageBox.Show("It looks like we're having troubles with the internet connection.");
            }
            else if (!isMySQLConnected)
            {
                MessageBox.Show("Oops, failed to establish a connection to the MySQL server. Please make sure your server is running and MySQL service is started.", "MySQL Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
            }
            else
            {
                // Both connections are okay, proceed with the application logic
                await OpenAuthnForm();
            }
        }

        private async Task<bool> IsInternetAvailableAsync()
        {
            try
            {
                Ping ping = new Ping();
                PingReply reply = await ping.SendPingAsync("www.google.com");
                return (reply != null && reply.Status == IPStatus.Success);
            }
            catch
            {
                return false;
            }
        }

        private async Task<bool> ConnectToMySQL()
        {
            try
            {
                // Check if MySQL server is running and the connection can be established
                Database db = new Database();

                if (db.GetConnection != null && db.GetConnection.State == ConnectionState.Open)
                {
                   return true; // MySQL connection successful
                }
                else
                {
                    return false; // MySQL connection failed
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while connecting to the MySQL server: {ex.Message}", "MySQL Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // MySQL connection failed due to an exception
            }
        }

        private void Reconnect_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // CheckConnectionStatus(); // Recheck connection status
        }


        private async Task OpenAuthnForm()
        {
            await Task.Run(() =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.Hide();
                    AuthnForm authnForm = new AuthnForm();
                    authnForm.ShowDialog();
                });
            });
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
