namespace CarRentalApp
{
    partial class Add_Edit_Vehicle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LicenseNum = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.Vin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMake = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbVin = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbLicenseNum = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LicenseNum, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Year, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Vin, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbMake, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbModel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbVin, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbYear, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbLicenseNum, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(458, 183);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LicenseNum
            // 
            this.LicenseNum.AutoSize = true;
            this.LicenseNum.Location = new System.Drawing.Point(3, 144);
            this.LicenseNum.Name = "LicenseNum";
            this.LicenseNum.Size = new System.Drawing.Size(111, 13);
            this.LicenseNum.TabIndex = 8;
            this.LicenseNum.Text = "License Plate Number";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(3, 108);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(29, 13);
            this.Year.TabIndex = 6;
            this.Year.Text = "Year";
            // 
            // Vin
            // 
            this.Vin.AutoSize = true;
            this.Vin.Location = new System.Drawing.Point(3, 72);
            this.Vin.Name = "Vin";
            this.Vin.Size = new System.Drawing.Size(25, 13);
            this.Vin.TabIndex = 4;
            this.Vin.Text = "VIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make";
            // 
            // tbMake
            // 
            this.tbMake.Location = new System.Drawing.Point(232, 3);
            this.tbMake.Name = "tbMake";
            this.tbMake.Size = new System.Drawing.Size(208, 20);
            this.tbMake.TabIndex = 9;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(232, 39);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(208, 20);
            this.tbModel.TabIndex = 10;
            // 
            // tbVin
            // 
            this.tbVin.Location = new System.Drawing.Point(232, 75);
            this.tbVin.Name = "tbVin";
            this.tbVin.Size = new System.Drawing.Size(208, 20);
            this.tbVin.TabIndex = 11;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(232, 111);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(208, 20);
            this.tbYear.TabIndex = 12;
            // 
            // tbLicenseNum
            // 
            this.tbLicenseNum.Location = new System.Drawing.Point(232, 147);
            this.tbLicenseNum.Name = "tbLicenseNum";
            this.tbLicenseNum.Size = new System.Drawing.Size(208, 20);
            this.tbLicenseNum.TabIndex = 13;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(171, 240);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(138, 23);
            this.btnSaveChanges.TabIndex = 1;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(171, 269);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(83, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 39);
            this.lblTitle.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(241, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Visible = false;
            // 
            // Add_Edit_Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 296);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Add_Edit_Vehicle";
            this.Text = "Add Edit Vehicle";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbLicenseNum;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbVin;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label LicenseNum;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Vin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMake;
        private System.Windows.Forms.Label lblId;
    }
}