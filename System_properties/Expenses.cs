using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using Green_house_chikale.Authn;
using Org.BouncyCastle.Utilities;
using System.IO;

namespace Green_house_chikale.System_properties
{
    public partial class Expenses : UserControl
    {
        public Expenses()
        {
            InitializeComponent();
        }

      Database db = new Database();
        private void Expenses_Load(object sender, EventArgs e)
        {
            try
            {        
                MySqlDataAdapter My = new MySqlDataAdapter("SELECT* FROM Expense", db.GetConnection);
                DataTable dTable = new DataTable();
                My.Fill(dTable);
                dataGridView1.DataSource = dTable;
                dataGridView1.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Datee.MaxDate = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //export table expenditure
            //Exporting Excell sheet of the expnse
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV|*.csv";
                saveFileDialog.Title = "Save exported data as";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    string path = saveFileDialog.FileName;
                    string query = "SELECT * FROM Expense ";
                    MySqlConnection conn = db.GetConnection;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    using (var writer = new StreamWriter(path))
                    {
                        writer.WriteLine(string.Join(",", dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName)));
                        foreach (DataRow row in dt.Rows)
                        {
                            writer.WriteLine(string.Join(",", row.ItemArray));
                        }
                    }
                    MessageBox.Show("Data exported successfully to " + path, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while exporting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            try
            {
                if (Description.Text == "" || Combo2.Text == "" || Amount.Text == "" || Combo.Text == "")
                {
                    MessageBox.Show("Unable to Submit.. Text fields cannot be left empty", "Error on Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        var date = DateTime.Now.ToString("yyyy-MM-dd"); // Correct date format for MySQL

                        db.OpenConnection();
                       
                        command.Connection = db.GetConnection;
                        command.CommandText = "INSERT INTO Expense VALUES (NULL, @Session, @Description, @Combo2, @Amount, @Combo, @Date)";
                        command.Parameters.AddWithValue("@Session", Signin.Sessions);
                        command.Parameters.AddWithValue("@Description", Description.Text);
                        command.Parameters.AddWithValue("@Combo2", Combo2.Text);
                        command.Parameters.AddWithValue("@Amount", Amount.Text);
                        command.Parameters.AddWithValue("@Combo", Combo.Text);
                        command.Parameters.AddWithValue("@Date", date);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data added successfully");
                        }
                        else
                        {
                            MessageBox.Show("Data not added");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error inserting data: " + ex.Message);
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MySqlDataAdapter My = new MySqlDataAdapter("SELECT * FROM Expense", db.GetConnection);
                DataTable dTable = new DataTable();
                My.Fill(dTable);
                dataGridView1.DataSource = dTable;
                dataGridView1.Columns["ID"].Visible = false;
            }
        }

        private void Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}