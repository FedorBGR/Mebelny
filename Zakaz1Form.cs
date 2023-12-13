using Org.BouncyCastle.Utilities;
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
    public partial class Zakaz1Form : Form
    {
        public Zakaz1Form()
        {
            InitializeComponent();
        }

        private void ReloadForm()
        {
            ZakazClass.GetZakaz();
            dataGridView1.DataSource = ZakazClass.dtZakaz;
            textBox_cena_zakaza.Text = "";
            textBox_client_name.Text = "";
            textBox_client_otch.Text = "";
            textBox_client_surname.Text = "";
            textBox_id_zakaz.Text = "";
            textBox_Search.Text = "";
            textBox_zakaz_col.Text = "";
            comboBox_id_tovar.Text = "";
            
            comboBox_satus.Text = "";
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmplForm empl1 = new EmplForm();
            empl1.Show();
        }
        private void DataIntoComboxIdTovar()
        {
            string sql = @"SELECT id_tovar FROM tovar";
            DBconnection.msCommand.CommandText= sql;
            using (var reader = DBconnection.msCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    comboBox_id_tovar.Items.Add(reader["id_tovar"].ToString());
                }
            }
        }

        private void DataIntoComboxj()
        {
            string sql = @"SELECT id_tovar FROM tovar";
            DBconnection.msCommand.CommandText = sql;
            using (var reader = DBconnection.msCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    comboBoxj.Items.Add(reader["id_tovar"].ToString());
                }
            }
        }

        private void DataIntoComboxIdEMpl()
        {
            
        }

        private void Zakaz1Form_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            textBoxj.Visible = false;
            comboBoxj.Visible = false;
            buttonAddvzakaz.Enabled = false;
            string surname = Autorization.Famil(textBox_fam.Text);
            textBox_fam.Text = surname;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            DataIntoComboxIdTovar();
            DataIntoComboxIdEMpl();
            DataIntoComboxj();
            ZakazClass.GetZakaz();
            dataGridView1.DataSource = ZakazClass.dtZakaz;
            buttonAddvzakaz.Enabled = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button_addZakaz_Click(object sender, EventArgs e)
        {
            string col_do = @"SELECT tovar_col FROM tovar WHERE id_tovar = '" + comboBox_id_tovar.Text + "'";
            DBconnection.msCommand.CommandText = col_do;
            Object resultcoldo = DBconnection.msCommand.ExecuteScalar();
            string v = @"SELECT tovar_cena FROM tovar WHERE id_tovar = '" + comboBox_id_tovar.Text + "'";
            DBconnection.msCommand.CommandText = v;
            Object result = DBconnection.msCommand.ExecuteScalar();
            if (result != null)
            {
                int price = Convert.ToInt32(result);
                int x = price;
                int y = Convert.ToInt32(textBox_zakaz_col.Text);
                int z = x * y;
                textBox_cena_zakaza.Text = z.ToString();
            }
            if (comboBox_id_tovar.Text != "" && textBox_client_name.Text != "" && textBox_client_surname.Text != "" && textBox_client_otch.Text != "" && textBox_zakaz_col.Text != "" && textBox_fam.Text != "" && comboBox_satus.Text != "")
            {

                int y = Convert.ToInt32(textBox_zakaz_col.Text);

                if (Convert.ToInt32(resultcoldo) > y)
                    
                    {
                    int k = Convert.ToInt32(textBox_zakaz_col.Text);
                    if (ZakazClass.addZakaz(comboBox_id_tovar.Text, textBox_client_name.Text, textBox_client_surname.Text, textBox_client_otch.Text, Convert.ToInt32(textBox_cena_zakaza.Text), Convert.ToInt32(textBox_zakaz_col.Text), textBox_fam.Text, comboBox_satus.Text))
                    {
                        int col_col = Convert.ToInt32(resultcoldo) - k;
                        string Obnovtov = @"UPDATE tovar SET tovar_col = '" + col_col + "' WHERE id_tovar = '" + comboBox_id_tovar.Text + "'";
                        DBconnection.msCommand.CommandText = Obnovtov;
                        Object resultobnov = DBconnection.msCommand.ExecuteScalar();
                        MessageBox.Show("Товар успешно добавлен в базу.", "Товар внесен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ZakazClass.GetZakaz();


                        textBox_cena_zakaza.Text = "";
                        comboBox_id_tovar.Text = "";
                        textBox_client_name.Text = "";
                        textBox_client_surname.Text = "";
                        textBox_client_otch.Text = "";
                        textBox_zakaz_col.Text = "";
                        comboBox_satus.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Товар не был добавлен!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }



                }
                else
                {
                    MessageBox.Show("Товара на складе едостаточно", "Товара недостаточно", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }

            }
            else
            {
                MessageBox.Show("Заполните обязательные полня!", "Полня не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static public string Idzakaz, Idtovar, ClientName, ClientSurname, ClientOthc, CenaZakaz, ZakazCol, IdEmpl, ZakazStatus;

        private void button_hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_toAut_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutorizationForm Aut = new AutorizationForm();
            Aut.Show();
        }

        private void button_vzakaz_Click(object sender, EventArgs e)
        {
            Idzakaz = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Idtovar = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            CenaZakaz = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            ZakazCol = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox_id_zakaz.Text = Idzakaz;
            buttonAddvzakaz.Enabled = true;
            textBoxj.Visible = true;
            comboBoxj.Visible = true;
            textBox_zakaz_col.Text = "";
            textBox_client_name.Enabled = false;
            textBox_client_otch.Enabled = false;
            textBox_client_surname.Enabled = false;
            comboBox_satus.Enabled = false;
        }

        private void buttonAddvzakaz_Click(object sender, EventArgs e)
        {
            string idt1 = Convert.ToString(comboBoxj.Text);
            comboBox_id_tovar.Text = idt1;
            int zkc1 = Convert.ToInt32(textBoxj.Text);
            textBox_zakaz_col.Text = zkc1.ToString();
            string col_do = @"SELECT tovar_col FROM tovar WHERE id_tovar = '" + comboBox_id_tovar.Text + "'";
            DBconnection.msCommand.CommandText = col_do;
            Object resultcoldo = DBconnection.msCommand.ExecuteScalar();
            string a = @"SELECT id_tovar FROM zakazy WHERE id_zakaz = '" + textBox_id_zakaz.Text + "'";
            DBconnection.msCommand.CommandText = a;
            Object result1 = DBconnection.msCommand.ExecuteScalar();
            string b = @"SELECT zakaz_cena FROM zakazy WHERE id_zakaz = '" + textBox_id_zakaz.Text + "'";
            DBconnection.msCommand.CommandText = b;
            Object result2 = DBconnection.msCommand.ExecuteScalar();
            string c = @"SELECT zakaz_col FROM zakazy WHERE id_zakaz = '" + textBox_id_zakaz.Text + "'";
            DBconnection.msCommand.CommandText = c;
            Object result3 = DBconnection.msCommand.ExecuteScalar();
            string v = @"SELECT tovar_cena FROM tovar WHERE id_tovar = '" + comboBox_id_tovar.Text + "'";

            DBconnection.msCommand.CommandText = v;
            Object result = DBconnection.msCommand.ExecuteScalar();
            if (result != null && result1 != null && result2 != null && result3 != null)
            {
                int j = Convert.ToInt32(textBoxj.Text);
                int price = Convert.ToInt32(result);
                int x = price;
                int y = Convert.ToInt32(textBoxj.Text);
                int z = x * y;
                textBox_cena_zakaza.Text = z.ToString();

                int colvo = Convert.ToInt32(result3);
                int colvo_posle = colvo + j;
                textBox_zakaz_col.Text = colvo_posle.ToString();

                int price2 = Convert.ToInt32(result2);
                int price_posle = price2 + z;
                textBox_cena_zakaza.Text = price_posle.ToString();

                string id_tov = result1.ToString();
                comboBox_id_tovar.Text = id_tov + ";" + comboBoxj.Text;



            }
            if (textBox_id_zakaz.Text == Idzakaz)
            {


                if (textBox_id_zakaz.Text != "" && comboBox_id_tovar.Text != "" && textBox_cena_zakaza.Text != "" && textBox_zakaz_col.Text != "")
                {
                    Idzakaz = textBox_id_zakaz.Text;
                    int j = Convert.ToInt32(textBoxj.Text);
                    if (Convert.ToInt32(resultcoldo) > j)
                    {
                        
                        if (ZakazClass.addTovartoZakaz(int.Parse(textBox_id_zakaz.Text), comboBox_id_tovar.Text, int.Parse(textBox_cena_zakaza.Text), int.Parse(textBox_zakaz_col.Text)))
                        {
                            int col_col = Convert.ToInt32(resultcoldo) - j;
                            string Obnovtov = @"UPDATE tovar SET tovar_col = '" + col_col + "' WHERE id_tovar = '" + comboBox_id_tovar.Text + "'";
                            DBconnection.msCommand.CommandText = Obnovtov;
                            Object resultobnov = DBconnection.msCommand.ExecuteScalar();
                            MessageBox.Show("Товар успешно добавлен в базу.", "Товар внесен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ZakazClass.GetZakaz();


                            textBox_cena_zakaza.Text = "";
                            comboBox_id_tovar.Text = "";
                            textBox_client_name.Text = "";
                            textBox_client_surname.Text = "";
                            textBox_client_otch.Text = "";
                            textBox_zakaz_col.Text = "";
                            comboBox_satus.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Товара на складе едостаточно", "Товара недостаточно", MessageBoxButtons.OK, MessageBoxIcon.Warning);MessageBox.Show("Ошибка при добавлении в заказ", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                    }
                    else
                    {
                        MessageBox.Show("Товара на складе едостаточно", "Товара недостаточно", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля", "Поля не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (ZakazClass.addTovartoZakaz(int.Parse(textBox_id_zakaz.Text), comboBox_id_tovar.Text, int.Parse(textBox_cena_zakaza.Text), int.Parse(textBox_zakaz_col.Text)))
                {
                    int j = Convert.ToInt32(textBoxj.Text);
                    if (Convert.ToInt32(resultcoldo) > j)
                    {
                        int col_col = Convert.ToInt32(resultcoldo) - j;
                        string Obnovtov = @"UPDATE tovar SET tovar_col = '" + col_col + "' WHERE id_tovar = '" + comboBox_id_tovar.Text + "'";
                        DBconnection.msCommand.CommandText = Obnovtov;
                        Object resultobnov = DBconnection.msCommand.ExecuteScalar();
                        MessageBox.Show("Товар успешно добавлен в базу.", "Товар внесен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ZakazClass.GetZakaz();


                        textBox_cena_zakaza.Text = "";
                        comboBox_id_tovar.Text = "";
                        textBox_client_name.Text = "";
                        textBox_client_surname.Text = "";
                        textBox_client_otch.Text = "";
                        textBox_zakaz_col.Text = "";
                        comboBox_satus.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Товара на складе едостаточно", "Товара недостаточно", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }



                }
                else
                {


                    if (textBox_id_zakaz.Text != "" && comboBox_id_tovar.Text != "" && textBox_cena_zakaza.Text != "" && textBox_zakaz_col.Text != "")
                    {
                        Idzakaz = textBox_id_zakaz.Text;
                        if (ZakazClass.addTovartoZakaz(int.Parse(textBox_id_zakaz.Text), comboBox_id_tovar.Text, int.Parse(textBox_cena_zakaza.Text), int.Parse(textBox_zakaz_col.Text)))
                        {
                            int j = Convert.ToInt32(textBoxj.Text);
                            if (Convert.ToInt32(resultcoldo) > j)
                            {
                                int col_col = Convert.ToInt32(resultcoldo) - j;
                                string Obnovtov = @"UPDATE tovar SET tovar_col = '" + col_col + "' WHERE id_tovar = '" + comboBox_id_tovar.Text + "'";
                                DBconnection.msCommand.CommandText = Obnovtov;
                                Object resultobnov = DBconnection.msCommand.ExecuteScalar();
                                MessageBox.Show("Товар успешно добавлен в базу.", "Товар внесен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ZakazClass.GetZakaz();


                                textBox_cena_zakaza.Text = "";
                                comboBox_id_tovar.Text = "";
                                textBox_client_name.Text = "";
                                textBox_client_surname.Text = "";
                                textBox_client_otch.Text = "";
                                textBox_zakaz_col.Text = "";
                                comboBox_satus.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Товара на складе едостаточно", "Товара недостаточно", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }



                        }
                        else
                        {
                            MessageBox.Show("Ошибка при добавлении в заказ", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заполните все поля", "Поля не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            textBoxj.Visible = false;
            comboBoxj.Visible = false;
            buttonAddvzakaz.Enabled = false;
            buttonAddvzakaz.Enabled = false;
            textBox_client_name.Enabled = false;
            textBox_client_otch.Enabled = false;
            textBox_client_surname.Enabled = false;
            comboBox_satus.Enabled = false;

        }


        private void textBox_client_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char f = e.KeyChar;
            if((f < 'А' || f > 'я') && f != '\b' && f != ' ' && (f < 'A' || f > 'z') )
            {
                e.Handled = true;
            }
        }

        private void textBox_client_surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char f = e.KeyChar;
            if ((f < 'А' || f > 'я') && f != '\b' && f != ' ' && (f < 'A' || f > 'z'))
            {
                e.Handled = true;
            }
        }

        private void textBox_client_otch_KeyPress(object sender, KeyPressEventArgs e)
        {
            char f = e.KeyChar;
            if ((f < 'А' || f > 'я') && f != '\b' && f != ' ' && (f < 'A' || f > 'z'))
            {
                e.Handled = true;
            }
        }

        private void textBox_zakaz_col_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBoxj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Zakaz1Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_reload_Click(object sender, EventArgs e)
        {
            ReloadForm();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Search.Text != "")
                {
                    string ZakazSearch = textBox_Search.Text;
                    ZakazClass.searchZakaz(ZakazSearch);

                    if (dataGridView1.RowCount == 0)
                    {
                        MessageBox.Show("Номер заказа не обнаружен", "Товар не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox_Search.Text = "";
                        ZakazClass.GetZakaz();
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

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_id_zakaz.Text == Idzakaz && comboBox_id_tovar.Text == Idtovar && textBox_client_name.Text == ClientName && textBox_client_surname.Text == ClientSurname && textBox_client_otch.Text == ClientOthc && textBox_cena_zakaza.Text == CenaZakaz && textBox_zakaz_col.Text == ZakazCol && textBox_fam.Text == IdEmpl && comboBox_satus.Text == ZakazStatus)
            {
                if (textBox_id_zakaz.Text != "" && comboBox_id_tovar.Text != "" && textBox_client_name.Text != "" && textBox_client_surname.Text != "" && textBox_client_otch.Text != "" && textBox_cena_zakaza.Text != "" && textBox_zakaz_col.Text != "" && textBox_fam.Text !="" && comboBox_satus.Text != "")
                {
                    Idzakaz = textBox_id_zakaz.Text ;
                    Idtovar = comboBox_id_tovar.Text ;
                    ClientName = textBox_client_name.Text;
                    ClientSurname = textBox_client_surname.Text;
                    ClientOthc = textBox_client_otch.Text;
                    CenaZakaz = textBox_cena_zakaza.Text;
                    ZakazCol = textBox_zakaz_col.Text;
                    IdEmpl = textBox_fam.Text;
                    ZakazStatus = comboBox_satus.Text;
                    if (ZakazClass.EditZakaz(int.Parse(textBox_id_zakaz.Text), comboBox_id_tovar.Text, textBox_client_name.Text, textBox_client_surname.Text, textBox_client_otch.Text, textBox_fam.Text, comboBox_satus.Text))
                    {
                        MessageBox.Show("Данные заказа успешно изменены", "Данные изменены", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ZakazClass.GetZakaz();
                        textBox_cena_zakaza.Text = "";
                        comboBox_id_tovar.Text = "";
                        textBox_client_name.Text = "";
                        textBox_client_surname.Text = "";
                        textBox_client_otch.Text = "";
                        textBox_zakaz_col.Text = "";
                        
                        comboBox_satus.Text = "";
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
                if (ZakazClass.EditZakaz(int.Parse(textBox_id_zakaz.Text), comboBox_id_tovar.Text, textBox_client_name.Text, textBox_client_surname.Text, textBox_client_otch.Text, textBox_fam.Text, comboBox_satus.Text))
                    {
                    MessageBox.Show("Данные заказа успешно изменены", "Данные изменены", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ZakazClass.GetZakaz();
                    textBox_cena_zakaza.Text = "";
                    comboBox_id_tovar.Text = "";
                    textBox_client_name.Text = "";
                    textBox_client_surname.Text = "";
                    textBox_client_otch.Text = "";
                    textBox_zakaz_col.Text = "";
                    
                    comboBox_satus.Text = "";
                }
                else
                {
                    if (textBox_id_zakaz.Text != "" && comboBox_id_tovar.Text != "" && textBox_client_name.Text != "" && textBox_client_surname.Text != "" && textBox_client_otch.Text != "" && textBox_cena_zakaza.Text != "" && textBox_zakaz_col.Text != "" && textBox_fam.Text != "" && comboBox_satus.Text != "")
                    {
                        Idzakaz = textBox_id_zakaz.Text;
                        Idtovar = comboBox_id_tovar.Text;
                        ClientName = textBox_client_name.Text;
                        ClientSurname = textBox_client_surname.Text;
                        ClientOthc = textBox_client_otch.Text;
                        CenaZakaz = textBox_cena_zakaza.Text;
                        ZakazCol = textBox_zakaz_col.Text;
                        IdEmpl = textBox_fam.Text;
                        ZakazStatus = comboBox_satus.Text;
                        if (ZakazClass.EditZakaz(int.Parse(textBox_id_zakaz.Text), comboBox_id_tovar.Text, textBox_client_name.Text, textBox_client_surname.Text, textBox_client_otch.Text, textBox_fam.Text, comboBox_satus.Text))
                        {
                            MessageBox.Show("Данные заказа успешно изменены", "Данные изменены", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ZakazClass.GetZakaz();
                            textBox_cena_zakaza.Text = "";
                            comboBox_id_tovar.Text = "";
                            textBox_client_name.Text = "";
                            textBox_client_surname.Text = "";
                            textBox_client_otch.Text = "";
                            textBox_zakaz_col.Text = "";
                            
                            comboBox_satus.Text = "";
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
            textBox_client_name.Enabled = true;
            textBox_client_otch.Enabled = true;
            textBox_client_surname.Enabled = true;
            comboBox_id_tovar.Enabled = true;
            textBox_zakaz_col.Enabled = true;
        }

        private void button_izm_Click(object sender, EventArgs e)
        {
            Idzakaz = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Idtovar = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ClientName = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ClientSurname = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ClientOthc = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            CenaZakaz = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            ZakazCol = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            IdEmpl = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            ZakazStatus = dataGridView1.CurrentRow.Cells[9].Value.ToString();

            textBox_id_zakaz.Text = Idzakaz;
            comboBox_id_tovar.Text = Idtovar;
            textBox_client_name.Text = ClientName;
            textBox_client_surname.Text = ClientSurname;
            textBox_client_otch.Text = ClientOthc;
            textBox_cena_zakaza.Text = CenaZakaz;
            textBox_zakaz_col.Text = ZakazCol;
            textBox_fam.Text = IdEmpl;
            comboBox_satus.Text = ZakazStatus;
            textBox_client_name.Enabled = false;
            textBox_client_otch.Enabled = false;
            textBox_client_surname.Enabled = false;
            comboBox_id_tovar.Enabled = false;
            textBox_zakaz_col.Enabled = false;
        }

    }
}
