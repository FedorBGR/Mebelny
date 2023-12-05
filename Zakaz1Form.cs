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

        private void DataIntoComboxIdEMpl()
        {
            string sql = @"SELECT id_acc FROM user";
            DBconnection.msCommand.CommandText = sql;
            using (var reader = DBconnection.msCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    comboBox_Id_user.Items.Add(reader["id_acc"].ToString());
                }
            }
        }

        private void Zakaz1Form_Load(object sender, EventArgs e)
        {
            DataIntoComboxIdTovar();
            DataIntoComboxIdEMpl();
            ZakazClass.GetZakaz();
            dataGridView1.DataSource = ZakazClass.dtZakaz;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button_addZakaz_Click(object sender, EventArgs e)
        {
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
            if (comboBox_id_tovar.Text != "" && textBox_client_name.Text != "" && textBox_client_surname.Text != "" && textBox_client_otch.Text != "" && textBox_zakaz_col.Text != "" && comboBox_Id_user.Text != "" && comboBox_satus.Text != "")
            {
                if (ZakazClass.addZakaz(Convert.ToInt32(comboBox_id_tovar.Text), textBox_client_name.Text, textBox_client_surname.Text, textBox_client_otch.Text,Convert.ToInt32(textBox_cena_zakaza.Text), Convert.ToInt32(textBox_zakaz_col.Text), Convert.ToInt32(comboBox_Id_user.Text), comboBox_satus.Text))
                                    {
                    MessageBox.Show("Товар успешно добавлен в базу.", "Товар внесен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ZakazClass.GetZakaz();
                    textBox_cena_zakaza.Text = "";
                    comboBox_id_tovar.Text = "";
                    textBox_client_name.Text = "";
                    textBox_client_surname.Text = "";
                    textBox_client_otch.Text = "";
                    textBox_zakaz_col.Text = "";
                    comboBox_Id_user.Text = "";
                    comboBox_satus.Text = "";
                }
                else
                {
                    MessageBox.Show("Товар не был добавлен!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Заполните обязательные полня!", "Полня не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static public string Idzakaz, Idtovar, ClientName, ClientSurname, ClientOthc, CenaZakaz, ZakazCol, IdEmpl, ZakazStatus;

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_id_zakaz.Text == Idzakaz && comboBox_id_tovar.Text == Idtovar && textBox_client_name.Text == ClientName && textBox_client_surname.Text == ClientSurname && textBox_client_otch.Text == ClientOthc && textBox_cena_zakaza.Text == CenaZakaz && textBox_zakaz_col.Text == ZakazCol && comboBox_Id_user.Text == IdEmpl && comboBox_satus.Text == ZakazStatus)
            {
                if (textBox_id_zakaz.Text != "" && comboBox_id_tovar.Text != "" && textBox_client_name.Text != "" && textBox_client_surname.Text != "" && textBox_client_otch.Text != "" && textBox_cena_zakaza.Text != "" && textBox_zakaz_col.Text != "" && comboBox_Id_user.Text !="" && comboBox_satus.Text != "")
                {
                    Idzakaz = textBox_id_zakaz.Text ;
                    Idtovar = comboBox_id_tovar.Text ;
                    ClientName = textBox_client_name.Text;
                    ClientSurname = textBox_client_surname.Text;
                    ClientOthc = textBox_client_otch.Text;
                    CenaZakaz = textBox_cena_zakaza.Text;
                    ZakazCol = textBox_zakaz_col.Text;
                    IdEmpl = comboBox_Id_user.Text;
                    ZakazStatus = comboBox_satus.Text;
                    if (ZakazClass.EditZakaz(int.Parse(textBox_id_zakaz.Text), int.Parse(comboBox_id_tovar.Text), textBox_client_name.Text, textBox_client_surname.Text, textBox_client_otch.Text, int.Parse(comboBox_Id_user.Text), comboBox_satus.Text))
                    {
                        MessageBox.Show("Данные заказа успешно изменены", "Данные изменены", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ZakazClass.GetZakaz();
                        textBox_cena_zakaza.Text = "";
                        comboBox_id_tovar.Text = "";
                        textBox_client_name.Text = "";
                        textBox_client_surname.Text = "";
                        textBox_client_otch.Text = "";
                        textBox_zakaz_col.Text = "";
                        comboBox_Id_user.Text = "";
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
                if (ZakazClass.EditZakaz(int.Parse(textBox_id_zakaz.Text), int.Parse(comboBox_id_tovar.Text), textBox_client_name.Text, textBox_client_surname.Text, textBox_client_otch.Text, int.Parse(comboBox_Id_user.Text), comboBox_satus.Text))
                    {
                    MessageBox.Show("Данные заказа успешно изменены", "Данные изменены", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ZakazClass.GetZakaz();
                    textBox_cena_zakaza.Text = "";
                    comboBox_id_tovar.Text = "";
                    textBox_client_name.Text = "";
                    textBox_client_surname.Text = "";
                    textBox_client_otch.Text = "";
                    textBox_zakaz_col.Text = "";
                    comboBox_Id_user.Text = "";
                    comboBox_satus.Text = "";
                }
                else
                {
                    if (textBox_id_zakaz.Text != "" && comboBox_id_tovar.Text != "" && textBox_client_name.Text != "" && textBox_client_surname.Text != "" && textBox_client_otch.Text != "" && textBox_cena_zakaza.Text != "" && textBox_zakaz_col.Text != "" && comboBox_Id_user.Text != "" && comboBox_satus.Text != "")
                    {
                        Idzakaz = textBox_id_zakaz.Text;
                        Idtovar = comboBox_id_tovar.Text;
                        ClientName = textBox_client_name.Text;
                        ClientSurname = textBox_client_surname.Text;
                        ClientOthc = textBox_client_otch.Text;
                        CenaZakaz = textBox_cena_zakaza.Text;
                        ZakazCol = textBox_zakaz_col.Text;
                        IdEmpl = comboBox_Id_user.Text;
                        ZakazStatus = comboBox_satus.Text;
                        if (ZakazClass.EditZakaz(int.Parse(textBox_id_zakaz.Text), int.Parse(comboBox_id_tovar.Text), textBox_client_name.Text, textBox_client_surname.Text, textBox_client_otch.Text, int.Parse(comboBox_Id_user.Text), comboBox_satus.Text))
                        {
                            MessageBox.Show("Данные заказа успешно изменены", "Данные изменены", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ZakazClass.GetZakaz();
                            textBox_cena_zakaza.Text = "";
                            comboBox_id_tovar.Text = "";
                            textBox_client_name.Text = "";
                            textBox_client_surname.Text = "";
                            textBox_client_otch.Text = "";
                            textBox_zakaz_col.Text = "";
                            comboBox_Id_user.Text = "";
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
            comboBox_Id_user.Text = IdEmpl;
            comboBox_satus.Text = ZakazStatus;
        }

    }
}
