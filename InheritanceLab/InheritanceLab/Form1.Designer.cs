namespace InheritanceLab
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.btnDisplayMostExpensiveCar = new System.Windows.Forms.Button();
            this.btnDisplayByMakes = new System.Windows.Forms.Button();
            this.btnDisplayByID = new System.Windows.Forms.Button();
            this.btnDisplayCheapestCar = new System.Windows.Forms.Button();
            this.cboCarType = new System.Windows.Forms.ComboBox();
            this.btnDisplayByType = new System.Windows.Forms.Button();
            this.btnTotalPrice = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.cboCustomerID = new System.Windows.Forms.ComboBox();
            this.cboMake = new System.Windows.Forms.ComboBox();
            this.txtChangePrice = new System.Windows.Forms.TextBox();
            this.btnChangePrice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(15, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1078, 288);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "       Make";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Model";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mileage";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Year";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Price";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 116;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Engine Size";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 130;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Average MPG";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 141;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "0 To 60";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 108;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Max Towing";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Customer ID";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 141;
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAll.Location = new System.Drawing.Point(15, 299);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(155, 45);
            this.btnDisplayAll.TabIndex = 1;
            this.btnDisplayAll.Text = "Display All Cars";
            this.btnDisplayAll.UseVisualStyleBackColor = true;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // btnDisplayMostExpensiveCar
            // 
            this.btnDisplayMostExpensiveCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayMostExpensiveCar.Location = new System.Drawing.Point(226, 299);
            this.btnDisplayMostExpensiveCar.Name = "btnDisplayMostExpensiveCar";
            this.btnDisplayMostExpensiveCar.Size = new System.Drawing.Size(155, 45);
            this.btnDisplayMostExpensiveCar.TabIndex = 2;
            this.btnDisplayMostExpensiveCar.Text = "Display Most Expensive Car";
            this.btnDisplayMostExpensiveCar.UseVisualStyleBackColor = true;
            this.btnDisplayMostExpensiveCar.Click += new System.EventHandler(this.btnDisplayMostExpensiveCar_Click);
            // 
            // btnDisplayByMakes
            // 
            this.btnDisplayByMakes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayByMakes.Location = new System.Drawing.Point(607, 299);
            this.btnDisplayByMakes.Name = "btnDisplayByMakes";
            this.btnDisplayByMakes.Size = new System.Drawing.Size(141, 23);
            this.btnDisplayByMakes.TabIndex = 7;
            this.btnDisplayByMakes.Text = "Display By Make";
            this.btnDisplayByMakes.UseVisualStyleBackColor = true;
            this.btnDisplayByMakes.Click += new System.EventHandler(this.btnDisplayByMakes_Click);
            // 
            // btnDisplayByID
            // 
            this.btnDisplayByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayByID.Location = new System.Drawing.Point(775, 299);
            this.btnDisplayByID.Name = "btnDisplayByID";
            this.btnDisplayByID.Size = new System.Drawing.Size(141, 23);
            this.btnDisplayByID.TabIndex = 8;
            this.btnDisplayByID.Text = "Display By ID";
            this.btnDisplayByID.UseVisualStyleBackColor = true;
            this.btnDisplayByID.Click += new System.EventHandler(this.btnDisplayByID_Click);
            // 
            // btnDisplayCheapestCar
            // 
            this.btnDisplayCheapestCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayCheapestCar.Location = new System.Drawing.Point(431, 299);
            this.btnDisplayCheapestCar.Name = "btnDisplayCheapestCar";
            this.btnDisplayCheapestCar.Size = new System.Drawing.Size(155, 45);
            this.btnDisplayCheapestCar.TabIndex = 9;
            this.btnDisplayCheapestCar.Text = "Display Cheapest Car";
            this.btnDisplayCheapestCar.UseVisualStyleBackColor = true;
            this.btnDisplayCheapestCar.Click += new System.EventHandler(this.btnDisplayCheapestCar_Click);
            // 
            // cboCarType
            // 
            this.cboCarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCarType.FormattingEnabled = true;
            this.cboCarType.Items.AddRange(new object[] {
            "Car",
            "SportsCar",
            "Truck"});
            this.cboCarType.Location = new System.Drawing.Point(952, 323);
            this.cboCarType.Margin = new System.Windows.Forms.Padding(2);
            this.cboCarType.Name = "cboCarType";
            this.cboCarType.Size = new System.Drawing.Size(141, 21);
            this.cboCarType.TabIndex = 10;
            // 
            // btnDisplayByType
            // 
            this.btnDisplayByType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayByType.Location = new System.Drawing.Point(952, 299);
            this.btnDisplayByType.Name = "btnDisplayByType";
            this.btnDisplayByType.Size = new System.Drawing.Size(141, 23);
            this.btnDisplayByType.TabIndex = 12;
            this.btnDisplayByType.Text = "Display By Type";
            this.btnDisplayByType.UseVisualStyleBackColor = true;
            this.btnDisplayByType.Click += new System.EventHandler(this.btnDisplayByType_Click);
            // 
            // btnTotalPrice
            // 
            this.btnTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalPrice.Location = new System.Drawing.Point(952, 349);
            this.btnTotalPrice.Name = "btnTotalPrice";
            this.btnTotalPrice.Size = new System.Drawing.Size(141, 23);
            this.btnTotalPrice.TabIndex = 13;
            this.btnTotalPrice.Text = "Total Price";
            this.btnTotalPrice.UseVisualStyleBackColor = true;
            this.btnTotalPrice.Click += new System.EventHandler(this.btnTotalPrice_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(958, 375);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(66, 24);
            this.lblTotalPrice.TabIndex = 14;
            this.lblTotalPrice.Text = "label4";
            // 
            // cboCustomerID
            // 
            this.cboCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomerID.FormattingEnabled = true;
            this.cboCustomerID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.cboCustomerID.Location = new System.Drawing.Point(775, 323);
            this.cboCustomerID.Name = "cboCustomerID";
            this.cboCustomerID.Size = new System.Drawing.Size(141, 21);
            this.cboCustomerID.TabIndex = 15;
            // 
            // cboMake
            // 
            this.cboMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMake.FormattingEnabled = true;
            this.cboMake.Items.AddRange(new object[] {
            "Toyota",
            "Cadillac",
            "Ford",
            "Volkswagen",
            "Mazda",
            "Subaru",
            "Chevrolet",
            "Audi",
            "Dodge",
            "Ferrari",
            "Nissan",
            "Honda",
            "Lamborghini"});
            this.cboMake.Location = new System.Drawing.Point(607, 323);
            this.cboMake.Name = "cboMake";
            this.cboMake.Size = new System.Drawing.Size(141, 21);
            this.cboMake.TabIndex = 16;
            // 
            // txtChangePrice
            // 
            this.txtChangePrice.Location = new System.Drawing.Point(1114, 165);
            this.txtChangePrice.Name = "txtChangePrice";
            this.txtChangePrice.Size = new System.Drawing.Size(141, 20);
            this.txtChangePrice.TabIndex = 18;
            // 
            // btnChangePrice
            // 
            this.btnChangePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePrice.Location = new System.Drawing.Point(1114, 191);
            this.btnChangePrice.Name = "btnChangePrice";
            this.btnChangePrice.Size = new System.Drawing.Size(141, 23);
            this.btnChangePrice.TabIndex = 19;
            this.btnChangePrice.Text = "Change Price";
            this.btnChangePrice.UseVisualStyleBackColor = true;
            this.btnChangePrice.Click += new System.EventHandler(this.btnChangePrice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1110, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Change Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1111, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "1. Enter Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1111, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "2. Select Vehicle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1111, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "3. Click \"Change Price\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1267, 407);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangePrice);
            this.Controls.Add(this.txtChangePrice);
            this.Controls.Add(this.cboMake);
            this.Controls.Add(this.cboCustomerID);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnTotalPrice);
            this.Controls.Add(this.btnDisplayByType);
            this.Controls.Add(this.cboCarType);
            this.Controls.Add(this.btnDisplayCheapestCar);
            this.Controls.Add(this.btnDisplayByID);
            this.Controls.Add(this.btnDisplayByMakes);
            this.Controls.Add(this.btnDisplayMostExpensiveCar);
            this.Controls.Add(this.btnDisplayAll);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.Button btnDisplayMostExpensiveCar;
        private System.Windows.Forms.Button btnDisplayByMakes;
        private System.Windows.Forms.Button btnDisplayByID;
        private System.Windows.Forms.Button btnDisplayCheapestCar;
        private System.Windows.Forms.ComboBox cboCarType;
        private System.Windows.Forms.Button btnDisplayByType;
        private System.Windows.Forms.Button btnTotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.ComboBox cboCustomerID;
        private System.Windows.Forms.ComboBox cboMake;
        private System.Windows.Forms.TextBox txtChangePrice;
        private System.Windows.Forms.Button btnChangePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}

