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
    public partial class TovarEmpForm : Form
    {
        public TovarEmpForm()
        {
            InitializeComponent();
        }

        private void ReloadForm()
        {
            TovarClass.GetTovar();
            dataGridView1.DataSource = TovarClass.dtTovar;
            textBox_cena.Text = "";
            textBox_col.Text = "";
            textBox_id.Text = "";
            textBox_name.Text = "";
            textBox_postav.Text = "";
            textBox_Search.Text = "";

        }

        static public string EditId, EditName, EditCol, EditCena, EditPostav;

        private void button_reload_Click(object sender, EventArgs e)
        {
            ReloadForm();
        }

        private void TovarEmpForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized; 
            TovarClass.GetTovar();
            dataGridView1.DataSource = TovarClass.dtTovar;
        }

        private void TovarEmpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_toAut_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutorizationForm Aut = new AutorizationForm();
            Aut.Show();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label_id_Click(object sender, EventArgs e)
        {

        }

        private void textBox_col_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_cena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Search.Text != "")
                {
                    string tovarSearch = textBox_Search.Text;
                    TovarClass.searchTovar(tovarSearch);

                    if (dataGridView1.RowCount == 0)
                    {
                        MessageBox.Show("Совпадений не найдено, возможно вы допустили ошибку", "Товар не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox_Search.Text = "";
                        TovarClass.GetTovar();
                    }


                }

                else
                {
                    MessageBox.Show("Введите данные в поле поиска", "Нет данных для поиска", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при поиске", "Search ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmplForm empl1 = new EmplForm();
            empl1.Show();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text == EditName && textBox_col.Text == EditCol && textBox_cena.Text == EditCena && textBox_postav.Text == EditPostav)
            {
                if (textBox_name.Text != "" && textBox_col.Text != "" && textBox_cena.Text != "" && textBox_postav.Text != "")
                {
                    EditId = textBox_id.Text;
                    EditName = textBox_name.Text;
                    EditCol = textBox_col.Text;
                    EditPostav = textBox_postav.Text;
                    EditCena = textBox_cena.Text;
                    if (TovarClass.EditTovar(int.Parse(textBox_id.Text), textBox_name.Text, int.Parse(textBox_col.Text), int.Parse(textBox_cena.Text), textBox_postav.Text))
                    {
                        MessageBox.Show("Данные товара успешно изменены", "Данные изменены", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TovarClass.GetTovar();
                        textBox_cena.Text = "";
                        textBox_col.Text = "";
                        textBox_id.Text = "";
                        textBox_name.Text = "";
                        textBox_postav.Text = "";
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
            else
            {
                if (TovarClass.EditTovar(int.Parse(textBox_id.Text), textBox_name.Text, int.Parse(textBox_col.Text), int.Parse(textBox_cena.Text), textBox_postav.Text))
                {
                    MessageBox.Show("Данные товара успешно изменены", "Данные изменены", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TovarClass.GetTovar();
                    textBox_cena.Text = "";
                    textBox_col.Text = "";
                    textBox_id.Text = "";
                    textBox_name.Text = "";
                    textBox_postav.Text = "";

                }
                else
                {
                    if (textBox_name.Text != "" && textBox_col.Text != "" && textBox_cena.Text != "" && textBox_postav.Text != "")
                    {
                        EditId = textBox_id.Text;
                        EditName = textBox_name.Text;
                        EditCol = textBox_col.Text;
                        EditPostav = textBox_postav.Text;
                        EditCena = textBox_cena.Text;
                        if (TovarClass.EditTovar(int.Parse(textBox_id.Text), textBox_name.Text, int.Parse(textBox_col.Text), int.Parse(textBox_cena.Text), textBox_postav.Text))
                        {
                            MessageBox.Show("Данные товара успешно изменены", "Данные изменены", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TovarClass.GetTovar();
                            textBox_cena.Text = "";
                            textBox_col.Text = "";
                            textBox_id.Text = "";
                            textBox_name.Text = "";
                            textBox_postav.Text = "";
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
        }

        private void button_izm_Click(object sender, EventArgs e)
        {
            EditId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            EditName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            EditCol = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            EditCena = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            EditPostav = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            textBox_id.Text = EditId;

            textBox_name.Text = EditName;

            textBox_col.Text = EditCol;

            textBox_cena.Text = EditCena;

            textBox_postav.Text = EditPostav;
        }
    }
}
