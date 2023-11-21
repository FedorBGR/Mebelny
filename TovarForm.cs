using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mebelny
{
    public partial class TovarForm : Form
    {
        public TovarForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm admin = new AdminForm();
            admin.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_addtovar_Click(object sender, EventArgs e)
        {
            if(textBox_col.Text != "" && textBox_name.Text != "" && textBox_postav.Text !="" && textBox_cena.Text != "")
            {
                string sql = @"SELECT id_tovar FROM tovar WHERE tovar_name = '" + textBox_name + "'";
                DBconnection.msCommand.CommandText= sql;
                Object result = DBconnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("Такой товар уже есть в базе!", "Дубликат записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_name.Text = "";
                }
                else
                {
                    if (TovarClass.addTovar(textBox_name.Text, int.Parse( textBox_col.Text), int.Parse(textBox_cena.Text), textBox_postav.Text))
                    {
                        MessageBox.Show("Товар успешно добавлен в базу.", "Товар внесен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TovarClass.GetTovar();
                        textBox_cena.Text = "";
                        textBox_col.Text = "";
                        textBox_id.Text = "";
                        textBox_name.Text = "";
                        textBox_postav.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Товар не был добавлен!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните обязательные полня!", "Полня не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TovarForm_Load(object sender, EventArgs e)
        {
            TovarClass.GetTovar();
            dataGridView1.DataSource = TovarClass.dtTovar;
        }


        static public string EditId, EditName, EditCol, EditCena, EditPostav;
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
        
        

        private void button_save_Click(object sender, EventArgs e)
        {
            if(textBox_name.Text == EditName && textBox_col.Text == EditCol && textBox_cena.Text == EditCena && textBox_postav.Text == EditPostav)
            {
                if (textBox_name.Text != "" && textBox_col.Text != "" && textBox_cena.Text != "" && textBox_postav.Text != "")
                {
                    EditId = textBox_id.Text;
                    EditName = textBox_name.Text;
                    EditCol = textBox_col.Text;
                    EditPostav= textBox_postav.Text;
                    EditCena= textBox_cena.Text;
                    if(TovarClass.EditTovar(int.Parse(textBox_id.Text), textBox_name.Text, int.Parse(textBox_col.Text), int.Parse(textBox_cena.Text), textBox_postav.Text))
                    {
                    MessageBox.Show("Данные товара успешно изменены", "Данные изменены",MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if(TovarClass.EditTovar(int.Parse(textBox_id.Text), textBox_name.Text, int.Parse(textBox_col.Text), int.Parse(textBox_cena.Text), textBox_postav.Text))
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
    }
}
