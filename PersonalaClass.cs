using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mebelny
{
    internal class PersonalaClass : DBconnection
    {
        static public DataTable dtPers = new DataTable();

        static public void GetPerson()
        {
            try
            {
                msCommand.CommandText = "SELECT id_acc AS 'Код сотрудника', username AS 'Логин сотрудника',     password AS 'Пароль сотрудника', id_role AS 'Код роли сотрудника', surname AS 'Фамилия' FROM user";
                dtPers.Clear();
                msDataAdapter.SelectCommand = DBconnection.msCommand;
                msDataAdapter.Fill(dtPers);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool addPers(string username, string password, int id_role, string surname)
        {
            try
            {
                msCommand.CommandText = "INSERT INTO user VALUES (null , '" + username + "', '" + password + "', default , '" + id_role + "', '" + surname + "')";
                if (msCommand.ExecuteNonQuery()> 0)
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
                MessageBox.Show("Ошибка при добавлении сотрудника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool EditPers(int id_acc, string username, string password, int id_role, string surname)
        {
            try
            {
                msCommand.CommandText = "UPDATE user SET username = '" + username + "' , password = '" + password + "' , id_role = '" + id_role + "' , surname = '" + id_role + "' WHERE id_acc = '" + id_acc + "'";

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

        static public void deletePers(string id_acc)
        {
            try
            {
                msCommand.CommandText = "DELETE FROM user WHERE id_acc = '" + id_acc + "'";
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении выбранной записи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
