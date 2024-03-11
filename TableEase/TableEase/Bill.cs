using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TableEase
{
    public partial class Bill : Form
    {
        private int rId;
        private int bId;
        private String waiter;
        private decimal subtotal;
        private decimal tip;
        private decimal tax;
        private decimal total;

        private string cName;
        private DateTime rDate;
        private int tId;

        public Bill()
        {
            InitializeComponent();
           
        }

        public Bill(int rId)
        {
            InitializeComponent();
            this.rId = rId;
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.SelectedColor;

            try
            {
                using (SqlConnection connection = Connector.GetConnection())
                {
                    SqlCommand command = new SqlCommand("SELECT cName, rDate, tId FROM Reservation WHERE rId = @rId", connection);
                    command.Parameters.AddWithValue("@rId", rId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cName = (String)reader["cName"];
                            rDate = (DateTime)reader["rDate"];
                            tId = (int)reader["tId"];

                            nameTextLabel.Text = cName;
                            dateTextLabel.Text = rDate.ToShortDateString();
                            tableTextLabel.Text = tId.ToString();
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Color selectedColor = GetSelectedColor();
            var newForm = new MainMenu();
            newForm.SetBackgroundColor(selectedColor);
            newForm.Show();
            this.Hide();
        }
        
        private Color GetSelectedColor()
        {
            Color selectedColor = Color.LightGray;

            if (Properties.Settings.Default.SelectedColor != null)
            {
                try
                {
                    selectedColor = (Color)Properties.Settings.Default.SelectedColor;
                }
                catch (Exception e)
                {
                    MessageBox.Show($"{e}");
                }
            }

            
            string colorName = ConfigurationManager.AppSettings["SelectedColor"];
            if (!string.IsNullOrEmpty(colorName))
            {
                try
                {
                    selectedColor = Color.FromName(colorName);
                }
                catch (Exception e)
                {
                    MessageBox.Show($"{e}");
                }
            }

            return selectedColor;
        }

        private void waiterTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void subTotalTextBox_TextChanged(object sender, EventArgs e)
        {
            subtotal = decimal.Parse(subTotalTextBox.Text);
            tax = decimal.Multiply(subtotal, 0.14975M);
            total = subtotal + tax;
            taxTextLabel.Text = tax.ToString();
            totalTextLabel.Text = total.ToString();
        }

        private void tipTextBox_TextChanged(object sender, EventArgs e)
        {
            tip = decimal.Parse(tipTextBox.Text);
            total = subtotal + tax + tip;
            totalTextLabel.Text = total.ToString();
        }
    }
}
