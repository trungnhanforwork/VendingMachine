namespace VendingMachineForm
{
    partial class CartForm
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
            flowLayoutPanelCart = new FlowLayoutPanel();
            btnPay = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanelCart
            // 
            flowLayoutPanelCart.Location = new Point(12, 149);
            flowLayoutPanelCart.Margin = new Padding(3, 5, 3, 5);
            flowLayoutPanelCart.Name = "flowLayoutPanelCart";
            flowLayoutPanelCart.Size = new Size(673, 527);
            flowLayoutPanelCart.TabIndex = 0;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.LightSalmon;
            btnPay.Location = new Point(706, 212);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(210, 57);
            btnPay.TabIndex = 1;
            btnPay.Text = "Pay and print the order";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSalmon;
            button2.Location = new Point(706, 149);
            button2.Name = "button2";
            button2.Size = new Size(210, 57);
            button2.TabIndex = 2;
            button2.Text = "Continue order...";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(405, 43);
            label1.Name = "label1";
            label1.Size = new Size(154, 35);
            label1.TabIndex = 3;
            label1.Text = "YOUR ORDER";
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(928, 690);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(btnPay);
            Controls.Add(flowLayoutPanelCart);
            Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "CartForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelCart;
        private Button btnPay;
        private Button button2;
        private Label label1;
    }
}