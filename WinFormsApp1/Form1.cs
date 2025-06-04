using System;
using System.Data.Odbc;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string relativePath;
        private string connectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.FromArgb(245, 245, 245);
                btn.ForeColor = Color.Black;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2();
            //f2.Show();
            //this.Hide();
        }

    }
}
