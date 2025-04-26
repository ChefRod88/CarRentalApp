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
    public partial class AddEditVehicle : Form
    {
        private bool isEditMode;
        private readonly CarRentalEntitiesUpdated _db;
        public AddEditVehicle()
        {
            InitializeComponent();
            lblTitle.Text = "Add New Vehicle";
            isEditMode = false;
            _db = new CarRentalEntitiesUpdated();
        }

        public AddEditVehicle(TypesOfCar carToEdit)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Vehicle";
            isEditMode = true;
            _db = new CarRentalEntitiesUpdated();
            PopulateFields(carToEdit);
            
        }

        private void PopulateFields(TypesOfCar car)
        {
           lblTitle.Text = car.id.ToString();
           tbMake.Text = car.Make;
           tbModel.Text = car.Model;
           tbVin.Text = car.VIN;
           tbYear.Text = car.Year.ToString();
           tbLicenseNum.Text = car.LicensePlateNumber;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if(isEditMode == true)
            if (isEditMode)
            {
                // Edit code
                var id = int.Parse(lblid.Text);
                var car = _db.TypesOfCars.FirstOrDefault(q => q.id == id );
                car.Model = tbModel.Text;
                car.Make = tbMake.Text;
                car.VIN = tbVin.Text;
                car.Year = int.Parse(tbYear.Text);
                car.LicensePlateNumber = tbLicenseNum.Text;

                _db.SaveChanges();
            }
            else 
            {
                // Add codde
                var newCar = new TypesOfCar
                {
                    LicensePlateNumber = tbLicenseNum.Text,
                    Make = tbMake.Text,
                    Model = tbModel.Text,
                    VIN = tbVin.Text,
                    Year = int.Parse(tbYear.Text)

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
