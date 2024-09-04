namespace VendingMachineForm
{
    partial class FrmGuest
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
            flowLayoutPanelCategories = new FlowLayoutPanel();
            flowLayoutPanelProducts = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLayoutPanelCategories
            // 
            flowLayoutPanelCategories.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelCategories.Location = new Point(12, 13);
            flowLayoutPanelCategories.Name = "flowLayoutPanelCategories";
            flowLayoutPanelCategories.Size = new Size(164, 467);
            flowLayoutPanelCategories.TabIndex = 0;
            // 
            // flowLayoutPanelProducts
            // 
            flowLayoutPanelProducts.AutoScroll = true;
            flowLayoutPanelProducts.Location = new Point(182, 15);
            flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            flowLayoutPanelProducts.Size = new Size(750, 530);
            flowLayoutPanelProducts.TabIndex = 1;
            // 
            // FrmGuest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(944, 629);
            Controls.Add(flowLayoutPanelProducts);
            Controls.Add(flowLayoutPanelCategories);
            Name = "FrmGuest";
            Text = "FrmGuest";
            Load += FrmGuest_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelCategories;
        private FlowLayoutPanel flowLayoutPanelProducts;
    }
}