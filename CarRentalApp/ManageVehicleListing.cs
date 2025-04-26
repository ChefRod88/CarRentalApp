using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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
            //Select * From TypesOfCars
            //var cars = _db.TypesOfCars.ToList();

            //var cars = _db.TypesOfCars
            //    .Select(q => new { CarId = q.Id, CarName = q.Name }) //lambda expression
            //    .ToList();

            var cars = _db.TypesOfCars
                .Select(q => new 
                { 
                    q.Make, //custom name is same 
                    q.Model,
                    q.VIN,
                    q.Year,
                    q.LicensePlateNumber,
                    q.id,
                })
                .ToList();
            gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[4].HeaderText = "License Plate Number"; // custom header text
            gvVehicleList.Columns[5].Visible = false; // its there but it will not show up
            //gvVehicleList.Columns[0].HeaderText = "ID";
            //gvVehicleList.Columns[1].HeaderText = "NAME";
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            var addEditVehicle = new AddEditVehicle();
            addEditVehicle.MdiParent = this.MdiParent;
            addEditVehicle.Show();
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            // get Id of selected row
            
            var id = (int)gvVehicleList.SelectedRows[0].Cells["id"].Value;

            //query database for record
            var car = _db.TypesOfCars.FirstOrDefault(q => q.id == id);


            //launch AddEditVheicle window with data
            var addEditVehicle = new AddEditVehicle(car);
            addEditVehicle.MdiParent = this.MdiParent;
            addEditVehicle.Show();
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            // get Id of selected row
            var id = (int)gvVehicleList.SelectedRows[0].Cells["id"].Value;

            //query database for record
            var car = _db.TypesOfCars.FirstOrDefault(q => q.id == id);

            //delete vehicle from table
            _db.TypesOfCars.Remove(car);
            _db.SaveChanges();

            gvVehicleList.Refresh();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Simple Refresh Option
            PopulateGrid();
        }

        public void PopulateGrid()
        {
            // Select a custom model collection of cars from database
            var cars = _db.TypesOfCars
                .Select(q => new
                {
                    Make = q.Make,
                    Model = q.Model,
                    VIN = q.VIN,
                    Year = q.Year,
                    LicensePlateNumber = q.LicensePlateNumber,
                    q.id
                })
                .ToList();
            gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[4].HeaderText = "License Plate Number";
            //Hide the column for ID. Changed from the hard coded column value to the name, 
            // to make it more dynamic. 
            gvVehicleList.Columns["Id"].Visible = false;
        }
    }
    
}
