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
            var add_Edit_Vehicle = new Add_Edit_Vehicle();
            add_Edit_Vehicle.MdiParent = this.MdiParent;
            add_Edit_Vehicle.Show();
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            // get Id of selected row
            var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;

            //query database for record
            var car = _db.TypesOfCars.FirstOrDefault(q => q.id == id);


            //launch AddEditVheicle window with data
            var add_Edit_Vehicle = new Add_Edit_Vehicle(car);
            add_Edit_Vehicle.MdiParent = this.MdiParent;
            add_Edit_Vehicle.Show();
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            // get Id of selected row
            var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;

            //query database for record
            var car = _db.TypesOfCars.FirstOrDefault(q => q.id == id);

            //delete vehicle from table
            _db.TypesOfCars.Remove(car);
            _db.SaveChanges();

            gvVehicleList.Refresh();

        }
    }
}
