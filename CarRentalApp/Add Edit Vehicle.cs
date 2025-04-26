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
    public partial class Add_Edit_Vehicle : Form
    {
        private bool isEditMode;
        private readonly CarRentalEntitiesUpdated _db;
        public Add_Edit_Vehicle()
        {
            InitializeComponent();
            lblTitle.Text = "Add New Vehicle";
            isEditMode = false;
            _db = new CarRentalEntitiesUpdated();
        }

        public Add_Edit_Vehicle(TypesOfCar carToEdit)
        {
            InitializeComponent();
            _db = new CarRentalEntitiesUpdated();

            lblTitle.Text = "Edit Vehicle";
            PopulateFields(carToEdit);
            isEditMode = true;


        }

        private void PopulateFields(TypesOfCar car)
        {
            lblId.Text = car.id.ToString();
            tbMake.Text = car.Make;
            tbModel.Text = car.Model;
            Vin.Text = car.VIN;
            Year.Text = car.Year.ToString();
            LicenseNum.Text = car.LicensePlateNumber;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // if(isEditMode == true)
            if (isEditMode) 
            { 
                // Edit Code here
                var id = int.Parse(lblTitle.Text);
                var car = _db.TypesOfCars.FirstOrDefault(q => q.id == id);
                car.Model = tbModel.Text;
                car.Make = tbMake.Text;
                car.VIN = tbVin.Text;
                car.Year = int.Parse(tbYear.Text);
                car.LicensePlateNumber = tbLicenseNum.Text;

                _db.SaveChanges();

            }
            else
            {
              
                // Add Code Here
                var newCar = new TypesOfCar
                {
                    LicensePlateNumber = tbLicenseNum.Text,
                    Make = tbMake.Text,
                    Model = tbModel.Text,
                    VIN = tbVin.Text,
                    Year = int.Parse(tbYear.Text),
                };
                _db.TypesOfCars.Add(newCar);
                _db.SaveChanges();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
