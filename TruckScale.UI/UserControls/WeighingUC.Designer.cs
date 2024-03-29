﻿namespace TruckScale.UI.UserControls
{
    partial class WeighingUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label13 = new Label();
            txtNetWeight = new TextBox();
            txtSecondWeight = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtId = new TextBox();
            txtTicket = new TextBox();
            cboCustomer = new ComboBox();
            cboSupplier = new ComboBox();
            cboProduct = new ComboBox();
            txtRemarks = new TextBox();
            txtQuantity = new TextBox();
            txtPlateNumber = new TextBox();
            txtFirstWeight = new TextBox();
            btnUpdate = new Button();
            txtDriver = new TextBox();
            txtWeighInDate = new TextBox();
            txtWeighOutDate = new TextBox();
            btnClose = new Button();
            btnSave = new Button();
            panel3 = new Panel();
            label15 = new Label();
            label9 = new Label();
            label14 = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(408, 79);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(37, 13);
            label13.TabIndex = 26;
            label13.Text = "Driver";
            label13.Visible = false;
            // 
            // txtNetWeight
            // 
            txtNetWeight.BorderStyle = BorderStyle.None;
            txtNetWeight.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtNetWeight.Location = new Point(471, 364);
            txtNetWeight.Margin = new Padding(2, 2, 2, 2);
            txtNetWeight.Name = "txtNetWeight";
            txtNetWeight.ReadOnly = true;
            txtNetWeight.Size = new Size(99, 20);
            txtNetWeight.TabIndex = 24;
            txtNetWeight.TabStop = false;
            txtNetWeight.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSecondWeight
            // 
            txtSecondWeight.BorderStyle = BorderStyle.None;
            txtSecondWeight.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtSecondWeight.Location = new Point(471, 341);
            txtSecondWeight.Margin = new Padding(2, 2, 2, 2);
            txtSecondWeight.MaxLength = 7;
            txtSecondWeight.Name = "txtSecondWeight";
            txtSecondWeight.ReadOnly = true;
            txtSecondWeight.Size = new Size(99, 20);
            txtSecondWeight.TabIndex = 23;
            txtSecondWeight.TabStop = false;
            txtSecondWeight.TextAlign = HorizontalAlignment.Right;
            txtSecondWeight.DoubleClick += txtSecondWeight_DoubleClick;
            txtSecondWeight.Leave += txtSecondWeight_Leave;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(374, 367);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(78, 15);
            label12.TabIndex = 21;
            label12.Text = "NET WEIGHT";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(352, 345);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(103, 15);
            label11.TabIndex = 20;
            label11.Text = "SECOND WEIGHT";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(366, 322);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(87, 15);
            label10.TabIndex = 19;
            label10.Text = "FIRST WEIGHT";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(256, 255);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(51, 13);
            label8.TabIndex = 16;
            label8.Text = "Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(67, 255);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(50, 13);
            label7.TabIndex = 14;
            label7.Text = "Remarks";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 212);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(47, 13);
            label5.TabIndex = 13;
            label5.Text = "Product";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(67, 45);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(81, 13);
            label6.TabIndex = 6;
            label6.Text = "Ticket Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 168);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 13);
            label4.TabIndex = 4;
            label4.Text = "Supplier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 125);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 13);
            label2.TabIndex = 3;
            label2.Text = "Customer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 79);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 13);
            label3.TabIndex = 2;
            label3.Text = "Plate Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(408, 45);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 13);
            label1.TabIndex = 0;
            label1.Text = "Transaction ID";
            // 
            // txtId
            // 
            txtId.CharacterCasing = CharacterCasing.Upper;
            txtId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtId.Location = new Point(408, 59);
            txtId.Margin = new Padding(2, 2, 2, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(163, 23);
            txtId.TabIndex = 7;
            txtId.TabStop = false;
            // 
            // txtTicket
            // 
            txtTicket.CharacterCasing = CharacterCasing.Upper;
            txtTicket.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtTicket.Location = new Point(67, 59);
            txtTicket.Margin = new Padding(2, 2, 2, 2);
            txtTicket.Name = "txtTicket";
            txtTicket.ReadOnly = true;
            txtTicket.Size = new Size(163, 23);
            txtTicket.TabIndex = 9;
            txtTicket.TabStop = false;
            // 
            // cboCustomer
            // 
            cboCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboCustomer.FormattingEnabled = true;
            cboCustomer.Location = new Point(67, 140);
            cboCustomer.Margin = new Padding(2, 2, 2, 2);
            cboCustomer.Name = "cboCustomer";
            cboCustomer.Size = new Size(504, 21);
            cboCustomer.TabIndex = 3;
            // 
            // cboSupplier
            // 
            cboSupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboSupplier.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboSupplier.FormattingEnabled = true;
            cboSupplier.Location = new Point(67, 183);
            cboSupplier.Margin = new Padding(2, 2, 2, 2);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Size = new Size(504, 21);
            cboSupplier.TabIndex = 4;
            // 
            // cboProduct
            // 
            cboProduct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboProduct.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboProduct.FormattingEnabled = true;
            cboProduct.Location = new Point(67, 227);
            cboProduct.Margin = new Padding(2, 2, 2, 2);
            cboProduct.Name = "cboProduct";
            cboProduct.Size = new Size(504, 21);
            cboProduct.TabIndex = 5;
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(67, 281);
            txtRemarks.Margin = new Padding(2, 2, 2, 2);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(163, 58);
            txtRemarks.TabIndex = 7;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(322, 252);
            txtQuantity.Margin = new Padding(2, 2, 2, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(248, 22);
            txtQuantity.TabIndex = 6;
            // 
            // txtPlateNumber
            // 
            txtPlateNumber.CharacterCasing = CharacterCasing.Upper;
            txtPlateNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPlateNumber.Location = new Point(67, 94);
            txtPlateNumber.Margin = new Padding(2, 2, 2, 2);
            txtPlateNumber.Name = "txtPlateNumber";
            txtPlateNumber.Size = new Size(163, 23);
            txtPlateNumber.TabIndex = 1;
            // 
            // txtFirstWeight
            // 
            txtFirstWeight.BorderStyle = BorderStyle.None;
            txtFirstWeight.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtFirstWeight.Location = new Point(471, 319);
            txtFirstWeight.Margin = new Padding(2, 2, 2, 2);
            txtFirstWeight.MaxLength = 7;
            txtFirstWeight.Name = "txtFirstWeight";
            txtFirstWeight.ReadOnly = true;
            txtFirstWeight.Size = new Size(99, 20);
            txtFirstWeight.TabIndex = 22;
            txtFirstWeight.TabStop = false;
            txtFirstWeight.TextAlign = HorizontalAlignment.Right;
            txtFirstWeight.DoubleClick += txtFirstWeight_DoubleClick;
            txtFirstWeight.KeyPress += txtFirstWeight_KeyPress;
            txtFirstWeight.Leave += txtFirstWeight_Leave;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(74, 214, 109);
            btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(233, 236, 239);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(471, 383);
            btnUpdate.Margin = new Padding(2, 2, 2, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(99, 20);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtDriver
            // 
            txtDriver.Location = new Point(408, 94);
            txtDriver.Margin = new Padding(2, 2, 2, 2);
            txtDriver.Name = "txtDriver";
            txtDriver.Size = new Size(163, 22);
            txtDriver.TabIndex = 2;
            txtDriver.Visible = false;
            // 
            // txtWeighInDate
            // 
            txtWeighInDate.BorderStyle = BorderStyle.None;
            txtWeighInDate.Location = new Point(471, 277);
            txtWeighInDate.Margin = new Padding(2, 2, 2, 2);
            txtWeighInDate.Name = "txtWeighInDate";
            txtWeighInDate.ReadOnly = true;
            txtWeighInDate.Size = new Size(99, 15);
            txtWeighInDate.TabIndex = 30;
            // 
            // txtWeighOutDate
            // 
            txtWeighOutDate.BorderStyle = BorderStyle.None;
            txtWeighOutDate.Location = new Point(471, 298);
            txtWeighOutDate.Margin = new Padding(2, 2, 2, 2);
            txtWeighOutDate.Name = "txtWeighOutDate";
            txtWeighOutDate.ReadOnly = true;
            txtWeighOutDate.Size = new Size(99, 15);
            txtWeighOutDate.TabIndex = 31;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(33, 37, 41);
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(233, 236, 239);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.FromArgb(248, 249, 250);
            btnClose.Location = new Point(420, 413);
            btnClose.Margin = new Padding(2, 2, 2, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(57, 23);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(2, 62, 138);
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(233, 236, 239);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.FromArgb(248, 249, 250);
            btnSave.Location = new Point(496, 413);
            btnSave.Margin = new Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(74, 23);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 35, 35);
            panel3.Controls.Add(label15);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1114, 26);
            panel3.TabIndex = 1;
            // 
            // label15
            // 
            label15.Dock = DockStyle.Top;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(0, 0);
            label15.Name = "label15";
            label15.Size = new Size(1114, 26);
            label15.TabIndex = 0;
            label15.Text = "Weighing Transaction";
            label15.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(407, 277);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(54, 13);
            label9.TabIndex = 32;
            label9.Text = "Weigh In";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(407, 298);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(64, 13);
            label14.TabIndex = 33;
            label14.Text = "Weigh Out";
            // 
            // WeighingUC
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(label14);
            Controls.Add(label9);
            Controls.Add(btnClose);
            Controls.Add(txtNetWeight);
            Controls.Add(btnSave);
            Controls.Add(label13);
            Controls.Add(txtSecondWeight);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(panel3);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(txtFirstWeight);
            Controls.Add(label6);
            Controls.Add(btnUpdate);
            Controls.Add(txtTicket);
            Controls.Add(txtWeighInDate);
            Controls.Add(label8);
            Controls.Add(txtWeighOutDate);
            Controls.Add(txtRemarks);
            Controls.Add(label7);
            Controls.Add(txtDriver);
            Controls.Add(label5);
            Controls.Add(txtPlateNumber);
            Controls.Add(label4);
            Controls.Add(txtQuantity);
            Controls.Add(label2);
            Controls.Add(cboProduct);
            Controls.Add(label3);
            Controls.Add(cboSupplier);
            Controls.Add(cboCustomer);
            Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(2, 2, 2, 2);
            Name = "WeighingUC";
            Size = new Size(1114, 651);
            Load += WeighingUC_Load;
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox txtId;
        private TextBox txtPlateNumber;
        private TextBox txtTicket;
        private ComboBox cboCustomer;
        private ComboBox cboSupplier;
        private ComboBox cboProduct;
        private Label label8;
        private Label label7;
        private Label label5;
        private TextBox txtRemarks;
        private TextBox txtQuantity;
        private Label label13;
        private TextBox txtNetWeight;
        private TextBox txtSecondWeight;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox txtFirstWeight;
        private Button btnUpdate;
        private TextBox txtDriver;
        private TextBox txtWeighInDate;
        private TextBox txtWeighOutDate;
        private Button btnSave;
        private Button btnClose;
        private Panel panel3;
        private Label label15;
        private Label label9;
        private Label label14;
    }
}
