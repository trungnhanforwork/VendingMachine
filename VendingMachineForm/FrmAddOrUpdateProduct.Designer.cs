﻿namespace VendingMachineForm
{
    partial class FrmAddOrUpdateProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddOrUpdateProduct));
            btnSave = new Button();
            btnUpload = new Button();
            pictureBoxProductImage = new PictureBox();
            txtName = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            lblProductID = new Label();
            lblHeading = new Label();
            txtPrice = new TextBox();
            label1 = new Label();
            txtStock = new TextBox();
            label2 = new Label();
            label5 = new Label();
            cboCategory = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProductImage).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Yellow;
            btnSave.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(170, 505);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(303, 58);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(387, 329);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(107, 57);
            btnUpload.TabIndex = 4;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // pictureBoxProductImage
            // 
            pictureBoxProductImage.BackColor = SystemColors.HighlightText;
            pictureBoxProductImage.InitialImage = null;
            pictureBoxProductImage.Location = new Point(212, 302);
            pictureBoxProductImage.Name = "pictureBoxProductImage";
            pictureBoxProductImage.Size = new Size(102, 93);
            pictureBoxProductImage.TabIndex = 16;
            pictureBoxProductImage.TabStop = false;
            pictureBoxProductImage.Click += pictureBoxProductImage_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(212, 176);
            txtName.Name = "txtName";
            txtName.Size = new Size(317, 33);
            txtName.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(212, 120);
            txtId.Name = "txtId";
            txtId.Size = new Size(317, 33);
            txtId.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(90, 329);
            label4.Name = "label4";
            label4.Size = new Size(69, 29);
            label4.TabIndex = 13;
            label4.Text = "Image:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(90, 176);
            label3.Name = "label3";
            label3.Size = new Size(67, 29);
            label3.TabIndex = 12;
            label3.Text = "Name:";
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.ForeColor = Color.Yellow;
            lblProductID.Location = new Point(90, 120);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(113, 29);
            lblProductID.TabIndex = 11;
            lblProductID.Text = "Product ID: ";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.Yellow;
            lblHeading.Location = new Point(170, 34);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(324, 39);
            lblHeading.TabIndex = 10;
            lblHeading.Text = "ADD | UPDATE PRODUCT";
            lblHeading.Click += lblHeading_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(212, 235);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(137, 33);
            txtPrice.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(90, 235);
            label1.Name = "label1";
            label1.Size = new Size(60, 29);
            label1.TabIndex = 19;
            label1.Text = "Price:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(439, 238);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(90, 33);
            txtStock.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(366, 238);
            label2.Name = "label2";
            label2.Size = new Size(64, 29);
            label2.TabIndex = 21;
            label2.Text = "Stock:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Yellow;
            label5.Location = new Point(90, 433);
            label5.Name = "label5";
            label5.Size = new Size(94, 29);
            label5.TabIndex = 23;
            label5.Text = "Category:";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(210, 433);
            cboCategory.MaxDropDownItems = 5;
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(319, 37);
            cboCategory.TabIndex = 5;
            // 
            // FrmAddOrUpdateProduct
            // 
            AutoScaleDimensions = new SizeF(11F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Maroon;
            ClientSize = new Size(643, 616);
            Controls.Add(cboCategory);
            Controls.Add(label5);
            Controls.Add(txtStock);
            Controls.Add(label2);
            Controls.Add(txtPrice);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnUpload);
            Controls.Add(pictureBoxProductImage);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblProductID);
            Controls.Add(lblHeading);
            Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmAddOrUpdateProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add -  Update Product";
            Load += FrmAddOrUpdateProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxProductImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnUpload;
        private PictureBox pictureBoxProductImage;
        private TextBox txtName;
        private TextBox txtId;
        private Label label4;
        private Label label3;
        private Label lblProductID;
        private Label lblHeading;
        private TextBox txtPrice;
        private Label label1;
        private TextBox txtStock;
        private Label label2;
        private Label label5;
        private ComboBox cboCategory;
    }
}