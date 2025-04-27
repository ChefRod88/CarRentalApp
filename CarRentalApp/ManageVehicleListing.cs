using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalEntitiesUpdated _db;

        public ManageVehicleListing()
        {
            InitializeComponent();
            _db = new CarRentalEntitiesUpdated();
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            try
            {
                var addEditVehicle = new AddEditVehicle();
                addEditVehicle.MdiParent = this.MdiParent;
                addEditVehicle.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;
                var car = _db.TypesOfCars.FirstOrDefault(q => q.id == id);

                if (car != null)
                {
                    var addEditVehicle = new AddEditVehicle(car);
                    addEditVehicle.MdiParent = this.MdiParent;
                    addEditVehicle.Show();
                }
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show($"Invalid data type encountered: {ex.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"No row is selected: {ex.Message}", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;
                var car = _db.TypesOfCars.FirstOrDefault(q => q.id == id);

                if (car != null)
                {
                    var confirmResult = MessageBox.Show(
                        "Are you sure you want to delete this car?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        _db.TypesOfCars.Remove(car);
                        _db.SaveChanges();
                        PopulateGrid();
                    }
                    // If user clicks "No", nothing happens
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred while deleting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        public void PopulateGrid()
        {
            var cars = _db.TypesOfCars
                .Select(q => new
                {
                    Make = q.Make,
                    Model = q.Model,
                    VIN = q.VIN,
                    Year = q.Year,
                    LicensePlateNumber = q.LicensePlateNumber,
                    Id = q.id
                })
                .ToList();

            gvVehicleList.DataSource = cars;

            // Set column headers
            gvVehicleList.Columns["Make"].HeaderText = "Make";
            gvVehicleList.Columns["Model"].HeaderText = "Model";
            gvVehicleList.Columns["VIN"].HeaderText = "VIN";
            gvVehicleList.Columns["Year"].HeaderText = "Year";
            gvVehicleList.Columns["LicensePlateNumber"].HeaderText = "License Plate Number";

            // Hide the ID column
            gvVehicleList.Columns["Id"].Visible = false;

            // Auto-size the columns to fill the grid
            gvVehicleList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
