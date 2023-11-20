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

       

        private void button_izm_Click(object sender, EventArgs e)
        {
            EditTovarId1 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            EditTovarId2 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            EditTovarName1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            EditTovarName2 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            EditTovarCol1 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            EditTovarCol2 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            EditTovarCena1 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            EditTovarCena2 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            EditTovarPostav1 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            EditTovarPostav2 = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            textBox_id.Text = EditTovarId2;
            
            textBox_name.Text = EditTovarName2;
           
            textBox_col.Text = EditTovarCol2;
           
            textBox_cena.Text = EditTovarCena2;
            
            textBox_postav.Text = EditTovarPostav2;
           
        }
        
        static public string EditTovarName1, EditTovarName2, EditTovarCol1, EditTovarCol2, EditTovarCena1, EditTovarCena2, EditTovarPostav1, EditTovarPostav2,EditTovarId1, EditTovarId2;

        private void button_save_Click(object sender, EventArgs e)
        {
            if(textBox_name.Text == EditTovarName1 && textBox_col.Text == EditTovarCol1 && textBox_cena.Text == EditTovarCena1 && textBox_postav.Text == EditTovarPostav1 && textBox_id.Text == EditTovarId1)
            {
                if (textBox_name.Text != "" && textBox_col.Text != "" && textBox_cena.Text != "" && textBox_postav.Text != "" && textBox_id.Text != "")
                {
                    if(TovarClass.EditTovar(int.Parse(EditTovarId1), EditTovarName1, int.Parse(EditTovarCol1), int.Parse(EditTovarCena1), EditTovarPostav1))
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
                string sql = @"SELECT id_tovar FROM tovar WHERE tovar_name = '" + textBox_name.Text + "'";
                DBconnection.msCommand.CommandText= sql;
                Object result = DBconnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("Такой товар уже есть в базе!", "Дубликат записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_cena.Text = "";
                    textBox_col.Text = "";
                    textBox_id.Text = "";
                    textBox_name.Text = "";
                    textBox_postav.Text = "";

                }
                else
                {
                    if (textBox_name.Text != "" && textBox_col.Text != "" && textBox_cena.Text != "" && textBox_postav.Text != "" && textBox_id.Text != "")
                    {
                        if (TovarClass.EditTovar(int.Parse(EditTovarId2), EditTovarName2, int.Parse(EditTovarCol2), int.Parse(EditTovarCena2), EditTovarPostav2))
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
