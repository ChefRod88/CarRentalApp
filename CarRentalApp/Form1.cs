using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string customerName = tbCustomerName.Text;
            var dateOut = DateRented.Value;
            var dateIn = DateReturned.Value;
            string carType = TypeOfCar.SelectedItem?.ToString();
            bool isValid = true;
            StringBuilder errors = new StringBuilder();

            // Validate customer name and car type
            if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carType))
            {
                errors.AppendLine("Please enter missing data.");
                isValid = false;
            }

            // Validate dates
            if (dateOut > dateIn)
            {
                errors.AppendLine("Illegal Date Selection.");
                isValid = false;
            }

            // Validate cost
            double cost;
            if (!double.TryParse(tbCost.Text, out cost))
            {
                errors.AppendLine("Please enter a valid numeric cost.");
                isValid = false;
            }

            // Show errors or display final message
            if (!isValid)
            {
                MessageBox.Show(errors.ToString(), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"Customer Name: {customerName}\n\r" +
                                $"Date Rented: {dateOut:d}\n\r" +
                                $"Date Returned: {dateIn:d}\n\r" +
                                $"Cost: {cost:C}\n\r" +
                                $"Car Type: {carType}\n\r" +
                                $"THANK YOU FOR YOUR BUSINESS", "Rental Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
