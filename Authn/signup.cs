
using Green_house_chikale.Authn;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Green_house_chikale
{
    public partial class Signup : UserControl
    {
        public Signup()
        {
            InitializeComponent();
        }
        Database db = new Database();
        string Role = "Regular";
        //method of generating unuque Hex Code 
        private string GenDutyCode()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] bytes = new byte[3]; //adjust size as needed for RGB
                rng.GetBytes(bytes);
                Color color = Color.FromArgb(bytes[0], bytes[1], bytes[2]);
                return ColorToHex(color);
            }
        }
        //covert color to hex string
        private string ColorToHex(Color color)
        {
            return "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
        }
        private void Signup_btn_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            try
            {
                MySqlCommand cmd = new MySqlCommand("select username from Users where username='" + Email.Text + "'", db.GetConnection);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("User already exists in the server.\nPlease add a different username");
                }
                else
                {
                    db.OpenConnection();
                    command.Connection = db.GetConnection;
                    string uniqueHexCode = GenDutyCode();

                ///MessageBox.Show("Generated Hex:" + uniqueHexCode);

                    command.CommandText = "INSERT INTO users VALUES ('" + "" + "', '" + Firstname.Text + "','" + Surname.Text + "','" + Email.Text + "','" + Password.Text + "','" + Role + "','" + uniqueHexCode + "')";
                    command.ExecuteNonQuery();

                    MessageBox.Show("The account has been created successfully.\nYou can now log in to the account.", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Firstname.Clear();
                    Surname.Clear();
                    Email.Clear();
                    Password.Clear();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


    }
}
