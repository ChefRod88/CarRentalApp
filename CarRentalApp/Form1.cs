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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string customerName = tbCustomerName.Text;
            string dateOut = DateRented.Value.ToString();
            string dateIn = DateReturned.Value.ToString();

            var carType = TypeOfCar.SelectedItem.ToString();

            MessageBox.Show($"Customer Name: {customerName}\n\r" +
                $"Date Rented: {dateOut}\n\r" +
                $"Date Returned: {dateIn}\n\r" +
                $"Car Type: {carType}\n\r" +
                $"THANK YOU FOR YOUR BUSINESS");
        }
    }
}
