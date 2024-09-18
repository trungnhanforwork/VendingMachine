namespace VendingMachineForm
{
    partial class FrmAddOrUpdateCategory
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
            lblHeading = new Label();
            lblCategoryId = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            pictureBoxCategoryImage = new PictureBox();
            btnUpload = new Button();
            btnSaveCategory = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCategoryImage).BeginInit();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.Yellow;
            lblHeading.Location = new Point(119, 26);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(337, 39);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "ADD | UPDATE CATEGORY";
            // 
            // lblCategoryId
            // 
            lblCategoryId.AutoSize = true;
            lblCategoryId.ForeColor = Color.Yellow;
            lblCategoryId.Location = new Point(55, 117);
            lblCategoryId.Name = "lblCategoryId";
            lblCategoryId.Size = new Size(123, 29);
            lblCategoryId.TabIndex = 2;
            lblCategoryId.Text = "Category ID: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(55, 170);
            label3.Name = "label3";
            label3.Size = new Size(67, 29);
            label3.TabIndex = 3;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(53, 263);
            label4.Name = "label4";
            label4.Size = new Size(69, 29);
            label4.TabIndex = 4;
            label4.Text = "Image:";
            // 
            // txtId
            // 
            txtId.Location = new Point(197, 114);
            txtId.Name = "txtId";
            txtId.Size = new Size(317, 33);
            txtId.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(197, 170);
            txtName.Name = "txtName";
            txtName.Size = new Size(317, 33);
            txtName.TabIndex = 1;
            // 
            // pictureBoxCategoryImage
            // 
            pictureBoxCategoryImage.BackColor = SystemColors.HighlightText;
            pictureBoxCategoryImage.InitialImage = null;
            pictureBoxCategoryImage.Location = new Point(197, 230);
            pictureBoxCategoryImage.Name = "pictureBoxCategoryImage";
            pictureBoxCategoryImage.Size = new Size(119, 105);
            pictureBoxCategoryImage.TabIndex = 7;
            pictureBoxCategoryImage.TabStop = false;
            pictureBoxCategoryImage.Click += pictureBoxCategoryImage_Click;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(343, 255);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(102, 45);
            btnUpload.TabIndex = 2;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnSaveCategory
            // 
            btnSaveCategory.BackColor = Color.Yellow;
            btnSaveCategory.ForeColor = SystemColors.ActiveCaptionText;
            btnSaveCategory.Location = new Point(119, 392);
            btnSaveCategory.Name = "btnSaveCategory";
            btnSaveCategory.Size = new Size(343, 62);
            btnSaveCategory.TabIndex = 3;
            btnSaveCategory.Text = "Save";
            btnSaveCategory.UseVisualStyleBackColor = false;
            btnSaveCategory.Click += button1_Click;
            // 
            // FrmAddOrUpdateCategory
            // 
            AutoScaleDimensions = new SizeF(11F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DarkRed;
            ClientSize = new Size(580, 521);
            Controls.Add(btnSaveCategory);
            Controls.Add(btnUpload);
            Controls.Add(pictureBoxCategoryImage);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblCategoryId);
            Controls.Add(lblHeading);
            Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAddOrUpdateCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Categories";
            Load += FrmAddOrUpdateCategory_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCategoryImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private Label lblCategoryId;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtName;
        private PictureBox pictureBoxCategoryImage;
        private Button btnUpload;
        private Button btnSaveCategory;
    }
}