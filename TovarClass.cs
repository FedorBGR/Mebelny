using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mebelny
{
    internal class TovarClass : DBconnection
    {
        static public DataTable dtTovar = new DataTable();

        static public void GetTovar()
        {
            try
            {
                msCommand.CommandText = "SELECT * FROM tovar";
                dtTovar.Clear();
                msDataAdapter.SelectCommand= DBconnection.msCommand;
                msDataAdapter.Fill(dtTovar);
            }
            catch 
            {
            MessageBox.Show("Ошибка при ролучкнии данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool addTovar(string tovar_name, int tovar_col, int tovar_cena, string tovar_postav)
        {
            try
            {
                msCommand.CommandText = "INSERT INTO tovar VALUES (null , '" + tovar_name + "', '" + tovar_col + "', '" + tovar_cena + "', '" + tovar_postav+ "')";
                if(msCommand.ExecuteNonQuery()> 0)
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

        static public bool EditTovar (int id_tovar, string tovar_name, int tovar_col, int tovar_cena, string tovar_postav)
        {
            try
            {
                msCommand.CommandText = "UPDATE tovar SET tovar_name = '" + tovar_name + "' , tovar_col = '" + tovar_col + "' , tovar_cena = '" + tovar_cena + "' , tovar_postav = '" + tovar_postav + "' WHERE id_tovar = '" + id_tovar + "'";
              
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
                MessageBox.Show("Ошибка при редактировании записи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                return false;
            }
        }
        
        static public void deleteTovar(string id_tovar)
        {
            try
            {
                msCommand.CommandText = "DELETE FROM tovar WHERE id_tovar = '" + id_tovar + "'";
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении выбранной записи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
