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
        private readonly CarRentalEntities carRentalEntities;
        public Form1()
        {
            InitializeComponent();
            carRentalEntities = new CarRentalEntities();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = tbCustomerName.Text;
                var dateOut = DateRented.Value;
                var dateIn = DateReturned.Value;
                string carType = TypeOfCar.Text;
                bool isValid = true;
                double cost = Convert.ToDouble(tbCost.Text);
                var errorMessage = "";


                // Validate customer name and car type
                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carType))
                {
                    isValid = false;
                    errorMessage += "Error: Please enter missing data.\n\r";
                }

                // Validate dates
                if (dateOut > dateIn)
                {
                    isValid = false;
                    errorMessage += "Error: Illegal Date Selection.\n\r";
                    
                }

               

                // Show errors or display final message
                if (isValid)
                {
                    MessageBox.Show($"Customer Name: {customerName}\n\r" +
                                    $"Date Rented: {dateOut:d}\n\r" +
                                    $"Date Returned: {dateIn:d}\n\r" +
                                    $"Cost: {cost}\n\r" +
                                    $"Car Type: {carType}\n\r" +
                                    $"THANK YOU FOR YOUR BUSINESS", "Rental Summary");
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Select * from TypesOfCars
            var cars = carRentalEntities.TypesOfCars.ToList();
            TypeOfCar.DisplayMember = "Name";
            TypeOfCar.ValueMember = "id";
            TypeOfCar.DataSource = cars; 
        }
    }
}
