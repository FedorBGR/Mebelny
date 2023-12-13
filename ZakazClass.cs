using Google.Protobuf.WellKnownTypes;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mebelny
{
    internal class ZakazClass: DBconnection
    {
        static public DataTable dtZakaz = new DataTable();

        static public void GetZakaz()
        {
            try
            {
                msCommand.CommandText = @"SELECT id_zakaz AS 'Номер закзаа', id_tovar AS 'Код товара', client_name AS 'Имя клиента', client_surname AS 'Фамилия клиента', client_otch AS 'Отчество клиента', zakaz_cena AS 'Цена заказа, Руб.', zakaz_col AS 'Общее количество товаров, Шт.', id_empl AS 'Обслуживал сотрудник', zakaz_time AS 'Время заказа', zakaz_ztatus AS 'Статус' FROM zakazy";
                dtZakaz.Clear();
                msDataAdapter.SelectCommand = DBconnection.msCommand;
                msDataAdapter.Fill(dtZakaz);
                

            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool addZakaz(string id_tovar, string client_name, string client_surname, string client_otch, int zakaz_cena, int zakaz_col, string id_empl, string zakaz_status)
        {
            string v = msCommand.CommandText = "SELECT tovar_cena FROM tovar WHERE id_tovar = '" + id_tovar + "'";
 
            try
            { 
                msCommand.CommandText = "INSERT INTO zakazy VALUES (null , '" + id_tovar + "', '" + client_name + "', '" + client_surname + "', '" + client_otch + "', '" + zakaz_cena + "', '" + zakaz_col + "', '" + id_empl + "', default, '" + zakaz_status + "')";
                if (msCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении записи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool addTovartoZakaz (int id_zakaz ,string id_tovar, int zakaz_cena, string zakaz_col)
        {
            string v = msCommand.CommandText = "SELECT id_tovar FROM zakazy WHERE id_zakaz = '" + id_zakaz + "'";
            string b = msCommand.CommandText = "SELECT zakaz_cena FROM zakazy WHERE id_zakaz = '" + id_zakaz + "'";
            string c = msCommand.CommandText = "SELECT zakaz_col FROM zakazy WHERE id_zakaz = '" + id_zakaz + "'";

            try
            {
                msCommand.CommandText = "UPDATE zakazy SET id_tovar =  '" + id_tovar + "' , zakaz_cena = '" + zakaz_cena + "', zakaz_col = '" + zakaz_col +"' WHERE id_zakaz = '" + id_zakaz +"'" ;

                if (msCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении в заказ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                return false;
            }
        }

        static public bool EditZakaz(int id_zakaz, string id_tovar, string client_name, string client_surname, string client_otch, string id_empl, string zakaz_status)
        {
            try
            {
                msCommand.CommandText = "UPDATE zakazy SET id_zakaz = '" + id_zakaz + "', id_tovar = '"+ id_tovar +"', client_name = '"+ client_name +"', client_surname = '"+ client_surname + "', client_otch = '"+ client_otch + "', id_empl = '" + id_empl + "', zakaz_ztatus = '"+ zakaz_status + "' WHERE id_zakaz = '" + id_zakaz +"'";
                //"UPDATE zakazy SET id_tovar = '" + id_tovar + "' , client_name = '" + client_name + "' , client_surname = '" + client_surname + "' , client_otch = '" + client_otch + "', id_empl = '" + id_empl + "', zakaz_ststus = '" +zakaz_status+ "' WHERE id_zakaz = '" + id_zakaz + "'";

                if (msCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при редактировании записи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public void searchZakaz(string zakazSearch)
        {
            try
            {
                msCommand.CommandText = @"SELECT id_zakaz AS 'Номер закзаа', id_tovar AS 'Код товара', client_name AS 'Имя клиента', client_surname AS 'Фамилия клиента', client_otch AS 'Отчество клиента', zakaz_cena AS 'Цена заказа, Руб.', zakaz_col AS 'Общее количество товаров, Шт', id_empl AS 'Обслуживал сотрудник', zakaz_time AS 'Время заказа', zakaz_ztatus AS 'Статус' FROM zakazy WHERE concat (id_zakaz) LIKE '" + zakazSearch + "' ";
                dtZakaz.Clear();
                msDataAdapter.SelectCommand = DBconnection.msCommand;
                msDataAdapter.Fill(dtZakaz);
            }
            catch
            {
                MessageBox.Show("Ошибка при поиске заказа", "Ошибка поиска", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static public void deleteZakaz(string id_zakaz)
        {
            try
            {
                string a = "SELECT id_tovar FROM zakazy WHERE id_zakaz = '" + id_zakaz + "'";
                msCommand.CommandText = a;
                var ares = msCommand.ExecuteNonQuery();
                string aidtov = ares.ToString();
                string [] id = aidtov.Split(';');
                
                string b = "SELECT zakaz_col FROM zakazy WHERE id_zakaz = '" + id_zakaz + "'";
                msCommand.CommandText = b;
                var bres = msCommand.ExecuteNonQuery();
                string bcol = bres.ToString();
                string[] col = bcol.Split(';');

                for (int i = 0; i < id.Length; i++)
                { 
                   
                    
                    int coli = int.Parse(col[i]);
                    
                    int idxz = int.Parse(id[i]);
                    
                    

                    msCommand.CommandText = $"update tovar set tovar_col = tovar_col + {coli} where id_tovar = {idxz}";
                    msCommand.ExecuteNonQuery();
                }
                

                msCommand.CommandText = "DELETE FROM zakazy WHERE id_zakaz = '" + id_zakaz + "'";
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении выбранной записи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
