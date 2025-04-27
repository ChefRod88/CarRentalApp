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
        private bool _saveSuccessful = false;

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
            try
            {
                if (isEditMode)
                {
                    // Edit code
                    var id = int.Parse(lblid.Text);
                    var car = _db.TypesOfCars.FirstOrDefault(q => q.id == id);

                    if (car != null)
                    {
                        car.Model = tbModel.Text;
                        car.Make = tbMake.Text;
                        car.VIN = tbVin.Text;
                        car.Year = int.Parse(tbYear.Text);
                        car.LicensePlateNumber = tbLicenseNum.Text;

                        _db.SaveChanges();
                        _saveSuccessful = true;
                        MessageBox.Show("Vehicle record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Car record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Add code
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
                    _saveSuccessful = true;
                    MessageBox.Show("New vehicle record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Input format error: {ex.Message}", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }








        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_saveSuccessful)
            {
                Close();
            }
            else
            {
                var result = MessageBox.Show("You haven't saved your changes yet. Are you sure you want to close?",
                                             "Unsaved Changes",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Close();
                }
                // If No, stay on the form
            }
        }

        
    }
}
