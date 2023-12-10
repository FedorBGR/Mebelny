using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mebelny
{
    public partial class EmplForm : Form
    {
        public EmplForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutorizationForm form = new AutorizationForm();
            form.Show();
        }

        private void button_tovary_Click(object sender, EventArgs e)
        {
            this.Hide();
            TovarEmpForm tovaremp = new TovarEmpForm();
            tovaremp.Show();
        }

        private void button_zakazy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zakaz1Form zakaz1= new Zakaz1Form();
            zakaz1.Show();
        }

        private void EmplForm_FormClosing(object sender, FormClosingEventArgs e)
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

