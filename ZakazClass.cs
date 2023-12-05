using Google.Protobuf.WellKnownTypes;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
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
                msCommand.CommandText = "SELECT * FROM zakazy";
                dtZakaz.Clear();
                msDataAdapter.SelectCommand = DBconnection.msCommand;
                msDataAdapter.Fill(dtZakaz);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool addZakaz(int id_tovar, string client_name, string client_surname, string client_otch, int zakaz_cena, int zakaz_col, int id_empl, string zakaz_status)
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

        static public bool EditZakaz(int id_zakaz, int id_tovar, string client_name, string client_surname, string client_otch, int id_empl, string zakaz_status)
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
    }
}
