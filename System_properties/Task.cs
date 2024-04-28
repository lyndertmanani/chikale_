using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Green_house_chikale.Authn;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;

namespace Green_house_chikale.System_properties
{
    public partial class Task : UserControl
    {
        public Task()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private Dictionary<string, string> userColorDict = new Dictionary<string, string>(); // Dictionary to store user IDs and their corresponding color codes
        private List <string> calendarDays = new List<string>(); // List to store calendar days

        private void Task_Load(object sender, EventArgs e)
        {
            try
            {
                LoadUserColors();
                SetDuties();
                MySqlDataAdapter My = new MySqlDataAdapter("SELECT * FROM  Users ", db.GetConnection);
                DataTable dTable = new DataTable();
                My.Fill(dTable);
                Members.DataSource = dTable;
                Members.Columns["ID"].Visible = false;
                Members.Columns["Username"].Visible = false; 
                Members.Columns["password"].Visible = false; 
                Members.Columns["roles"].Visible = false; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Members_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the current cell belongs to the "DutyHex" column and its value is not null or empty
            if (Members.Columns[e.ColumnIndex].Name == "DutyHex" && e.Value != null && !string.IsNullOrWhiteSpace(e.Value.ToString()))
            {
                try
                {
                    // Retrieve the Hex code from the cell value
                    string hexCode = e.Value.ToString();
                    // Convert the Hex code to a Color object
                    Color color = ColorTranslator.FromHtml(hexCode);
                    // Set the background color of the current cell to the converted Color object
                    e.CellStyle.BackColor = color;
                    // Set the foreground color of the text to the same color as the background
                    e.CellStyle.ForeColor = color;
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during color conversion
                    MessageBox.Show("Error occurred while formatting cell: " + ex.Message);
                }
            }
        }
        private void LoadUserColors()
        {
            try
            {
                db.OpenConnection(); // Assuming 'db' is your global Database instance

                string query = "SELECT id, DutyHex FROM Users"; // Assuming your table name is 'Users'
                using (MySqlCommand command = new MySqlCommand(query, db.GetConnection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string userID = reader["id"].ToString();
                            string colorCode = reader["DutyHex"].ToString();
                            userColorDict.Add(userID, colorCode);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void SetDuties()
        {
            try
            {
                List<string> users = new List<string>(userColorDict.Keys); // Get list of user IDs
                int daysPerUser = 4; // Number of working days per user

                DateTime startDate = DateTime.Today; // Start date for duties assignment (could be today or any other date)

                // Clear previous calendar days
                Duties.Controls.Clear();
                calendarDays.Clear();

                // Add labels for each day of the month
                for (int i = 1; i <= DateTime.DaysInMonth(startDate.Year, startDate.Month); i++)
                {
                    DateTime currentDate = new DateTime(startDate.Year, startDate.Month, i);
                    Label dayLabel = new Label();
                    dayLabel.Text = i.ToString();
                    dayLabel.AutoSize = false;
                    dayLabel.TextAlign = ContentAlignment.MiddleCenter;
                    dayLabel.Dock = DockStyle.Fill;
                    Duties.Controls.Add(dayLabel);

                    // Add date to the list of calendar days
                    calendarDays.Add(currentDate.ToString("yyyy-MM-dd"));
                }

                // Iterate through calendar days
                for (int i = 0; i < calendarDays.Count; i++)
                {
                    DateTime currentDate = DateTime.Parse(calendarDays[i]);

                    // Check if it's a weekday (assuming weekends are non-working days)
                    if (currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday)
                    {
                        // Assign duties to users for this day
                        int userIndex = i % users.Count; // Round-robin assignment
                        string userID = users[userIndex];
                        string colorCode = userColorDict[userID];

                        // Highlight the calendar day with the assigned color
                        Duties.Controls[i].BackColor = ColorTranslator.FromHtml(colorCode);
                    }
                    else
                    {
                        // If it's a weekend, do not assign duties
                        Duties.Controls[i].BackColor = Color.LightGray; // Or any other color for weekends
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error setting duties: " + ex.Message);
            }
        }
    }
}
