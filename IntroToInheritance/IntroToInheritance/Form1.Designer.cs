namespace IntroToInheritance
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
            this.btnCreateCircle = new System.Windows.Forms.Button();
            this.btnCreateCylinder = new System.Windows.Forms.Button();
            this.btnCreateSphere = new System.Windows.Forms.Button();
            this.btnCreateCone = new System.Windows.Forms.Button();
            this.btnGetSelectedShape = new System.Windows.Forms.Button();
            this.cboShapeNames = new System.Windows.Forms.ComboBox();
            this.btnComputeAvgVolAllShapes = new System.Windows.Forms.Button();
            this.btnComputeAvgVolumeByShape = new System.Windows.Forms.Button();
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
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(29, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(573, 186);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Radius";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Height";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Perimeter";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Area";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Volume";
            this.columnHeader6.Width = 90;
            // 
            // btnCreateCircle
            // 
            this.btnCreateCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCircle.Location = new System.Drawing.Point(28, 204);
            this.btnCreateCircle.Name = "btnCreateCircle";
            this.btnCreateCircle.Size = new System.Drawing.Size(284, 33);
            this.btnCreateCircle.TabIndex = 1;
            this.btnCreateCircle.Text = "Create Circle";
            this.btnCreateCircle.UseVisualStyleBackColor = true;
            this.btnCreateCircle.Click += new System.EventHandler(this.btnCreateCircle_Click);
            // 
            // btnCreateCylinder
            // 
            this.btnCreateCylinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCylinder.Location = new System.Drawing.Point(28, 243);
            this.btnCreateCylinder.Name = "btnCreateCylinder";
            this.btnCreateCylinder.Size = new System.Drawing.Size(284, 33);
            this.btnCreateCylinder.TabIndex = 2;
            this.btnCreateCylinder.Text = "Create Cylinder";
            this.btnCreateCylinder.UseVisualStyleBackColor = true;
            this.btnCreateCylinder.Click += new System.EventHandler(this.btnCreateCylinder_Click);
            // 
            // btnCreateSphere
            // 
            this.btnCreateSphere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSphere.Location = new System.Drawing.Point(29, 282);
            this.btnCreateSphere.Name = "btnCreateSphere";
            this.btnCreateSphere.Size = new System.Drawing.Size(284, 33);
            this.btnCreateSphere.TabIndex = 3;
            this.btnCreateSphere.Text = "Create Sphere";
            this.btnCreateSphere.UseVisualStyleBackColor = true;
            this.btnCreateSphere.Click += new System.EventHandler(this.btnCreateSphere_Click);
            // 
            // btnCreateCone
            // 
            this.btnCreateCone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCone.Location = new System.Drawing.Point(29, 321);
            this.btnCreateCone.Name = "btnCreateCone";
            this.btnCreateCone.Size = new System.Drawing.Size(284, 33);
            this.btnCreateCone.TabIndex = 4;
            this.btnCreateCone.Text = "Create Cone";
            this.btnCreateCone.UseVisualStyleBackColor = true;
            this.btnCreateCone.Click += new System.EventHandler(this.btnCreateCone_Click);
            // 
            // btnGetSelectedShape
            // 
            this.btnGetSelectedShape.Location = new System.Drawing.Point(351, 231);
            this.btnGetSelectedShape.Name = "btnGetSelectedShape";
            this.btnGetSelectedShape.Size = new System.Drawing.Size(220, 36);
            this.btnGetSelectedShape.TabIndex = 6;
            this.btnGetSelectedShape.Text = "Get Object of Selected Shape";
            this.btnGetSelectedShape.UseVisualStyleBackColor = true;
            this.btnGetSelectedShape.Click += new System.EventHandler(this.btnGetSelectedShape_Click);
            // 
            // cboShapeNames
            // 
            this.cboShapeNames.FormattingEnabled = true;
            this.cboShapeNames.Items.AddRange(new object[] {
            "Circle",
            "Sphere",
            "Cylinder",
            "Cone"});
            this.cboShapeNames.Location = new System.Drawing.Point(351, 204);
            this.cboShapeNames.Name = "cboShapeNames";
            this.cboShapeNames.Size = new System.Drawing.Size(220, 21);
            this.cboShapeNames.TabIndex = 7;
            // 
            // btnComputeAvgVolAllShapes
            // 
            this.btnComputeAvgVolAllShapes.Location = new System.Drawing.Point(351, 273);
            this.btnComputeAvgVolAllShapes.Name = "btnComputeAvgVolAllShapes";
            this.btnComputeAvgVolAllShapes.Size = new System.Drawing.Size(220, 36);
            this.btnComputeAvgVolAllShapes.TabIndex = 8;
            this.btnComputeAvgVolAllShapes.Text = "Compute Average Volume";
            this.btnComputeAvgVolAllShapes.UseVisualStyleBackColor = true;
            this.btnComputeAvgVolAllShapes.Click += new System.EventHandler(this.btnComputeAvgVolAllShapes_Click);
            // 
            // btnComputeAvgVolumeByShape
            // 
            this.btnComputeAvgVolumeByShape.Location = new System.Drawing.Point(351, 318);
            this.btnComputeAvgVolumeByShape.Name = "btnComputeAvgVolumeByShape";
            this.btnComputeAvgVolumeByShape.Size = new System.Drawing.Size(220, 36);
            this.btnComputeAvgVolumeByShape.TabIndex = 9;
            this.btnComputeAvgVolumeByShape.Text = "Compute Average Volume By Shape";
            this.btnComputeAvgVolumeByShape.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(609, 379);
            this.Controls.Add(this.btnComputeAvgVolumeByShape);
            this.Controls.Add(this.btnComputeAvgVolAllShapes);
            this.Controls.Add(this.cboShapeNames);
            this.Controls.Add(this.btnGetSelectedShape);
            this.Controls.Add(this.btnCreateCone);
            this.Controls.Add(this.btnCreateSphere);
            this.Controls.Add(this.btnCreateCylinder);
            this.Controls.Add(this.btnCreateCircle);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnCreateCircle;
        private System.Windows.Forms.Button btnCreateCylinder;
        private System.Windows.Forms.Button btnCreateSphere;
        private System.Windows.Forms.Button btnCreateCone;
        private System.Windows.Forms.Button btnGetSelectedShape;
        private System.Windows.Forms.ComboBox cboShapeNames;
        private System.Windows.Forms.Button btnComputeAvgVolAllShapes;
        private System.Windows.Forms.Button btnComputeAvgVolumeByShape;
    }
}

