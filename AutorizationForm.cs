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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Autorization.Autorization1(textBox1.Text, textBox2.Text);
                switch (Autorization.Role)
                {
                    case null:
                        {
                            MessageBox.Show("Такого пользователя не существует!", "Проверьте правильность введенных данных!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                    case "Администратор":
                        {
                            loginActive = textBox1.Text;
                            whois = "Администратор";
                            Autorization.User = textBox1.Text;
                            MessageBox.Show("Добро пожаловать в меню администратора", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            AdminForm admin = new AdminForm();
                            admin.Show();
                            break;
                        }
                    case "Продавец":
                        {
                            loginActive = textBox1.Text;
                            whois = "Продавец";
                            Autorization.User = textBox1.Text;
                            MessageBox.Show("Добро пожаловать в меню продаваца", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            EmplForm empl = new EmplForm();
                            empl.Show();
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Заполните все полня!", "Заполнение полей", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
