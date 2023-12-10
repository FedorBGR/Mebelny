using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mebelny
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutorizationForm form = new AutorizationForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TovarForm tovar = new TovarForm();
            tovar.Show();
        }

        private void button_zakazy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zakaz2Form zakaz2 = new Zakaz2Form();
            zakaz2.Show();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult close = MessageBox.Show("Вы хотите завершить работу?", "Завершить сеанс?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (close == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (close == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
