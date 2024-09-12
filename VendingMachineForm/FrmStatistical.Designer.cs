namespace VendingMachineForm
{
    partial class FrmStatistical
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
            panel1 = new Panel();
            cboMonth = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            dvgOrder = new DataGridView();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgOrder).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cboMonth);
            panel1.Location = new Point(-40, 47);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(624, 72);
            panel1.TabIndex = 3;
            // 
            // cboMonth
            // 
            cboMonth.FormattingEnabled = true;
            cboMonth.Location = new Point(349, 21);
            cboMonth.Name = "cboMonth";
            cboMonth.Size = new Size(92, 23);
            cboMonth.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(168, 6);
            label1.Name = "label1";
            label1.Size = new Size(251, 39);
            label1.TabIndex = 0;
            label1.Text = "MONTHLY REPORT";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(dvgOrder);
            panel2.Location = new Point(4, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(581, 323);
            panel2.TabIndex = 4;
            // 
            // dvgOrder
            // 
            dvgOrder.Anchor = AnchorStyles.Top;
            dvgOrder.BackgroundColor = SystemColors.ButtonFace;
            dvgOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgOrder.Location = new Point(3, 1);
            dvgOrder.Margin = new Padding(3, 2, 3, 2);
            dvgOrder.Name = "dvgOrder";
            dvgOrder.RowHeadersWidth = 51;
            dvgOrder.Size = new Size(575, 319);
            dvgOrder.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(227, 21);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 1;
            label2.Text = "Choose month";
            // 
            // FrmStatistical
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(597, 461);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmStatistical";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmStatistical";
            Load += FrmStatistical_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private ComboBox cboMonth;
        private Panel panel2;
        private DataGridView dvgOrder;
        private Label label2;
    }
}