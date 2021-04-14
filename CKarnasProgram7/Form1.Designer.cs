namespace CKarnasProgram7
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
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblBegOdom = new System.Windows.Forms.Label();
            this.lblEndOdom = new System.Windows.Forms.Label();
            this.lblDaysRented = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.nudMileageBegin = new System.Windows.Forms.NumericUpDown();
            this.nudDaysRented = new System.Windows.Forms.NumericUpDown();
            this.nudMileageEnd = new System.Windows.Forms.NumericUpDown();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpTruck = new System.Windows.Forms.GroupBox();
            this.grpBxTotal = new System.Windows.Forms.GroupBox();
            this.lblCharge = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMileageBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysRented)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMileageEnd)).BeginInit();
            this.grpTruck.SuspendLayout();
            this.grpBxTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Location = new System.Drawing.Point(12, 428);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(98, 13);
            this.lblDeveloper.TabIndex = 0;
            this.lblDeveloper.Text = "Developed by CGK";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(133, 34);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(152, 24);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name:";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBegOdom
            // 
            this.lblBegOdom.AutoSize = true;
            this.lblBegOdom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBegOdom.Location = new System.Drawing.Point(18, 79);
            this.lblBegOdom.Name = "lblBegOdom";
            this.lblBegOdom.Size = new System.Drawing.Size(267, 24);
            this.lblBegOdom.TabIndex = 3;
            this.lblBegOdom.Text = "Beginning Odometer Reading:";
            this.lblBegOdom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEndOdom
            // 
            this.lblEndOdom.AutoSize = true;
            this.lblEndOdom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndOdom.Location = new System.Drawing.Point(43, 127);
            this.lblEndOdom.Name = "lblEndOdom";
            this.lblEndOdom.Size = new System.Drawing.Size(242, 24);
            this.lblEndOdom.TabIndex = 5;
            this.lblEndOdom.Text = "Ending Odometer Reading:";
            this.lblEndOdom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDaysRented
            // 
            this.lblDaysRented.AutoSize = true;
            this.lblDaysRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysRented.Location = new System.Drawing.Point(163, 171);
            this.lblDaysRented.Name = "lblDaysRented";
            this.lblDaysRented.Size = new System.Drawing.Size(122, 24);
            this.lblDaysRented.TabIndex = 7;
            this.lblDaysRented.Text = "Days Rented:";
            this.lblDaysRented.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(352, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(274, 29);
            this.txtName.TabIndex = 2;
            // 
            // nudMileageBegin
            // 
            this.nudMileageBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMileageBegin.Location = new System.Drawing.Point(352, 77);
            this.nudMileageBegin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMileageBegin.Name = "nudMileageBegin";
            this.nudMileageBegin.Size = new System.Drawing.Size(274, 29);
            this.nudMileageBegin.TabIndex = 4;
            this.nudMileageBegin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudDaysRented
            // 
            this.nudDaysRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDaysRented.Location = new System.Drawing.Point(352, 171);
            this.nudDaysRented.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nudDaysRented.Name = "nudDaysRented";
            this.nudDaysRented.Size = new System.Drawing.Size(274, 29);
            this.nudDaysRented.TabIndex = 8;
            this.nudDaysRented.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudMileageEnd
            // 
            this.nudMileageEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMileageEnd.Location = new System.Drawing.Point(352, 125);
            this.nudMileageEnd.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMileageEnd.Name = "nudMileageEnd";
            this.nudMileageEnd.Size = new System.Drawing.Size(274, 29);
            this.nudMileageEnd.TabIndex = 6;
            this.nudMileageEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(317, 222);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(189, 37);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "&Create Truck Rental";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(528, 222);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(136, 37);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(543, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 37);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpTruck
            // 
            this.grpTruck.Controls.Add(this.nudMileageEnd);
            this.grpTruck.Controls.Add(this.nudDaysRented);
            this.grpTruck.Controls.Add(this.btnReset);
            this.grpTruck.Controls.Add(this.nudMileageBegin);
            this.grpTruck.Controls.Add(this.btnCreate);
            this.grpTruck.Controls.Add(this.txtName);
            this.grpTruck.Controls.Add(this.lblDaysRented);
            this.grpTruck.Controls.Add(this.lblEndOdom);
            this.grpTruck.Controls.Add(this.lblBegOdom);
            this.grpTruck.Controls.Add(this.lblCustomerName);
            this.grpTruck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTruck.Location = new System.Drawing.Point(15, 33);
            this.grpTruck.Name = "grpTruck";
            this.grpTruck.Size = new System.Drawing.Size(684, 272);
            this.grpTruck.TabIndex = 12;
            this.grpTruck.TabStop = false;
            this.grpTruck.Text = "Rental Form";
            // 
            // grpBxTotal
            // 
            this.grpBxTotal.Controls.Add(this.lblTotal);
            this.grpBxTotal.Controls.Add(this.lblCharge);
            this.grpBxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxTotal.Location = new System.Drawing.Point(15, 316);
            this.grpBxTotal.Name = "grpBxTotal";
            this.grpBxTotal.Size = new System.Drawing.Size(685, 67);
            this.grpBxTotal.TabIndex = 13;
            this.grpBxTotal.TabStop = false;
            this.grpBxTotal.Text = "Amount Due";
            // 
            // lblCharge
            // 
            this.lblCharge.AutoSize = true;
            this.lblCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharge.Location = new System.Drawing.Point(104, 22);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(181, 24);
            this.lblCharge.TabIndex = 11;
            this.lblCharge.Text = "Total Rental Charge:";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(352, 17);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(274, 35);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.grpBxTotal);
            this.Controls.Add(this.grpTruck);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDeveloper);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Truck Rental - Program 7";
            ((System.ComponentModel.ISupportInitialize)(this.nudMileageBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysRented)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMileageEnd)).EndInit();
            this.grpTruck.ResumeLayout(false);
            this.grpTruck.PerformLayout();
            this.grpBxTotal.ResumeLayout(false);
            this.grpBxTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblBegOdom;
        private System.Windows.Forms.Label lblEndOdom;
        private System.Windows.Forms.Label lblDaysRented;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown nudMileageBegin;
        private System.Windows.Forms.NumericUpDown nudDaysRented;
        private System.Windows.Forms.NumericUpDown nudMileageEnd;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpTruck;
        private System.Windows.Forms.GroupBox grpBxTotal;
        private System.Windows.Forms.Label lblCharge;
        private System.Windows.Forms.Label lblTotal;
    }
}

