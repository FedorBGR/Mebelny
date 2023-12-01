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
    }
}
