namespace VendingMachineForm
{
    public partial class HomeForm : Form
    {

        private Form currentPanelForm;
        public HomeForm()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem trong Panel2 đã có Form nào chưa
            if (currentPanelForm != null && !currentPanelForm.IsDisposed)
            {
                currentPanelForm.Close();  // Đóng Form trước khi Dispose
                currentPanelForm.Dispose();
            }
            ItPanelCategory f = new ItPanelCategory();
            if (f.Parent != null)
            {
                f.Parent.Controls.Remove(f);
            }
            // Thiết lập TopLevel, Dock và Parent cho UserControl
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(f);
            f.Show();
            currentPanelForm = f;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
