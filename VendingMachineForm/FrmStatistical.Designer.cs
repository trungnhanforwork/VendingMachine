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
            flowLayoutPanelMonth = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            dvgOrder = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgOrder).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelMonth
            // 
            flowLayoutPanelMonth.Location = new Point(12, 104);
            flowLayoutPanelMonth.Name = "flowLayoutPanelMonth";
            flowLayoutPanelMonth.Size = new Size(250, 378);
            flowLayoutPanelMonth.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(dvgOrder);
            flowLayoutPanel3.Location = new Point(268, 104);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(709, 388);
            flowLayoutPanel3.TabIndex = 2;
            // 
            // dvgOrder
            // 
            dvgOrder.BackgroundColor = SystemColors.ButtonFace;
            dvgOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgOrder.Location = new Point(3, 3);
            dvgOrder.Name = "dvgOrder";
            dvgOrder.RowHeadersWidth = 51;
            dvgOrder.Size = new Size(706, 375);
            dvgOrder.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(15, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 96);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(297, 27);
            label1.Name = "label1";
            label1.Size = new Size(353, 49);
            label1.TabIndex = 0;
            label1.Text = "THỐNG KÊ HÓA ĐƠN";
            // 
            // FrmStatistical
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(989, 494);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanelMonth);
            Name = "FrmStatistical";
            Text = "FrmStatistical";
            Load += FrmStatistical_Load;
            flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgOrder).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelMonth;
        private FlowLayoutPanel flowLayoutPanel3;
        private DataGridView dvgOrder;
        private Panel panel1;
        private Label label1;
    }
}