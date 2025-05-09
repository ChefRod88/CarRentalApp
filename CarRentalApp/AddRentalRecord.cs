﻿using System;
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
    public partial class AddRentalRecord : Form
    {
        private readonly CarRentalEntitiesUpdated carRentalEntities; // declared object which reprensents connection to the database
        public AddRentalRecord()
        {
            InitializeComponent();
            carRentalEntities = new CarRentalEntitiesUpdated(); // intialized database inside the constructor
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

               

                
                if (isValid)
                {
                    var rentalRecord = new CarRentalRecord();
                    rentalRecord.CustomerName = customerName;
                    rentalRecord.DateRented = dateOut;
                    rentalRecord.DateReturned = dateIn;
                    rentalRecord.Cost = (decimal)cost;
                    rentalRecord.TypesOfCarId = (int)TypeOfCar.SelectedValue;

                    
                    
                    carRentalEntities.CarRentalRecords.Add(rentalRecord);
                    carRentalEntities.SaveChanges();
                    
                  
                    

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
            //var cars = carRentalEntities.TypesOfCars.ToList();


            var cars = carRentalEntities.TypesOfCars
                .Select(q => new 
                { Id = q.id,
                    Name = q.Make
                    + " " 
                    + q.Model 
                }).ToList();
            TypeOfCar.DisplayMember = "Name";
            TypeOfCar.ValueMember = "Id";
            TypeOfCar.DataSource = cars; 
        }

        
    }
}
