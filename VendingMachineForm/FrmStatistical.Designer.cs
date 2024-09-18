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
            label2 = new Label();
            cboMonth = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            dvgOrder = new DataGridView();
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
            panel1.Location = new Point(12, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(816, 96);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(183, 29);
            label2.Name = "label2";
            label2.Size = new Size(150, 33);
            label2.TabIndex = 1;
            label2.Text = "Choose month";
            // 
            // cboMonth
            // 
            cboMonth.FormattingEnabled = true;
            cboMonth.Location = new Point(376, 34);
            cboMonth.Margin = new Padding(3, 4, 3, 4);
            cboMonth.Name = "cboMonth";
            cboMonth.Size = new Size(202, 28);
            cboMonth.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(271, 8);
            label1.Name = "label1";
            label1.Size = new Size(319, 49);
            label1.TabIndex = 0;
            label1.Text = "MONTHLY REPORT";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(dvgOrder);
            panel2.Location = new Point(12, 163);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(816, 448);
            panel2.TabIndex = 4;
            // 
            // dvgOrder
            // 
            dvgOrder.Anchor = AnchorStyles.Top;
            dvgOrder.BackgroundColor = SystemColors.ButtonHighlight;
            dvgOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgOrder.Location = new Point(3, 1);
            dvgOrder.Name = "dvgOrder";
            dvgOrder.RowHeadersWidth = 51;
            dvgOrder.Size = new Size(810, 444);
            dvgOrder.TabIndex = 1;
            // 
            // FrmStatistical
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(840, 638);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
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