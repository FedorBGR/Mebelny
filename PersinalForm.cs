using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mebelny
{
    public partial class PersinalForm : Form
    {
        public PersinalForm()
        {
            InitializeComponent();
        }

        private void PersinalForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            PersonalaClass.GetPerson();
            dataGridView1.DataSource = PersonalaClass.dtPers;
        }

        private void button_addtovar_Click(object sender, EventArgs e)
        {
            if (textBox_Login.Text != "" && textBox_password.Text != "" && comboBoxIdrole.Text != "" && textBoxSurname.Text != "")
            {
                string sql = @"SELECT id_acc FROM user WHERE username = '" + textBox_Login.Text + "'";
                DBconnection.msCommand.CommandText = sql;
                Object result = DBconnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("Этот логин занят!", "Дубликат записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Login.Text = "";
                }
                else
                {
                    if (PersonalaClass.addPers(textBox_Login.Text, textBox_password.Text, int.Parse(comboBoxIdrole.Text), textBoxSurname.Text))
                    {
                        MessageBox.Show("Товар успешно добавлен в базу.", "Товар внесен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PersonalaClass.GetPerson();
                        textBoxSurname.Text = "";
                        textBox_Login.Text = "";
                        textBox_id.Text = "";
                        textBox_password.Text = "";
                        comboBoxIdrole.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Сотрудник не был добавлен!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните обязательные полня!", "Полня не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static public string EditId, EditLogin, EditPassword, EditRole, EditSurname;

        private void button_deletetovar_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                DialogResult del = MessageBox.Show("Вы действительно хотите удалить человека?", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (del == DialogResult.Yes)
                {
                    PersonalaClass.deletePers(delete);
                    PersonalaClass.GetPerson();
                    dataGridView1.DataSource = PersonalaClass.dtPers;
                    MessageBox.Show("Товар удален", "Удаление завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении", "Не удалось удалить запись", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT id_acc FROM user WHERE username = '" + textBox_Login.Text + "' and id_acc != '" + textBox_id.Text + "'";
            DBconnection.msCommand.CommandText = sql;
            Object result = DBconnection.msCommand.ExecuteScalar();
            if (result != null)
            {
                MessageBox.Show("Этот логин занят!", "Дубликат записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Login.Text = "";
            }
            else
            {
                if (textBox_Login.Text != "" && textBox_password.Text != "" && comboBoxIdrole.Text != "" && textBoxSurname.Text != "")
                {
                    
                    if (PersonalaClass.EditPers(int.Parse(textBox_id.Text), textBox_Login.Text, textBox_password.Text, int.Parse( comboBoxIdrole.Text), textBoxSurname.Text))
                    {
                        MessageBox.Show("Данные товара успешно изменены", "Данные изменены", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PersonalaClass.GetPerson();
                        textBox_Login.Text = "";
                        textBox_password.Text = "";
                        textBox_id.Text = "";
                        comboBoxIdrole.Text = "";
                        textBoxSurname.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при редактировании записи", "Ошибка редактирования", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Заполните все поля", "Поля не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button_izm_Click(object sender, EventArgs e)
        {
            EditId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            EditLogin = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            EditPassword = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            EditRole = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            EditSurname = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            textBox_id.Text = EditId;

            textBox_Login.Text = EditLogin;

            textBox_password.Text = EditPassword;

            comboBoxIdrole.Text = EditRole;

            textBoxSurname.Text = EditSurname;
        }
    }
}
