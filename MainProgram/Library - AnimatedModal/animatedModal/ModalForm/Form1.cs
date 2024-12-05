using System;
using System.Drawing;
using System.Windows.Forms;

namespace modal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int parentX, parentY;
        private void button1_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (FrmModalForm modal = new FrmModalForm()) {

                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = this.Size;
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;

                parentX = this.Location.X;
                parentY = this.Location.Y;

                modal.ShowDialog();
                modalBackground.Dispose();


            }
        }
    }
}
