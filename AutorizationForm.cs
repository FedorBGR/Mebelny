using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using Application = System.Windows.Forms.Application;

namespace Mebelny
{
    public partial class AutorizationForm : Form
    {
        static public string loginActive;
        static public string whois;
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBconnection.ConnectionDB();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Autorization.Autorization1(textBox1.Text.Trim(), textBox2.Text.Trim());
                switch (Autorization.Role)
                {
                    case null:
                        {
                            MessageBox.Show("Такого пользователя не существует!", "Проверьте правильность введенных данных!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                    case "Администратор":
                        {
                            loginActive = textBox1.Text.Trim();
                            whois = "Администратор";
                            Autorization.User = textBox1.Text.Trim();
                            MessageBox.Show("Добро пожаловать в меню администратора", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            AdminForm admin = new AdminForm();
                            admin.Show();
                            break;
                        }
                    case "Продавец":
                        {
                            loginActive = textBox1.Text.Trim();
                            whois = "Продавец";
                            Autorization.User = textBox1.Text.Trim();
                            MessageBox.Show("Добро пожаловать в меню продавца", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            EmplForm empl = new EmplForm();
                            empl.Show();
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Заполнение полей", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AutorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }

        private void AutorizationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
