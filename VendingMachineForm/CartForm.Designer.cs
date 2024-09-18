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
            flowLayoutPanelCart.BackColor = Color.White;
            flowLayoutPanelCart.Location = new Point(40, 91);
            flowLayoutPanelCart.Margin = new Padding(3, 5, 3, 5);
            flowLayoutPanelCart.Name = "flowLayoutPanelCart";
            flowLayoutPanelCart.Size = new Size(898, 456);
            flowLayoutPanelCart.TabIndex = 0;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.Yellow;
            btnPay.Font = new Font("Sitka Heading", 16.1999989F);
            btnPay.Location = new Point(560, 566);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(213, 91);
            btnPay.TabIndex = 1;
            btnPay.Text = "Pay and print the order";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Font = new Font("Sitka Heading", 16.1999989F);
            button2.Location = new Point(188, 566);
            button2.Name = "button2";
            button2.Size = new Size(211, 91);
            button2.TabIndex = 2;
            button2.Text = "Continue order...";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Heading", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(372, 18);
            label1.Name = "label1";
            label1.Size = new Size(247, 53);
            label1.TabIndex = 3;
            label1.Text = "YOUR ORDER";
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(11F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(972, 703);
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