using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mebelny
{
    internal class Autorization
    {
        static public string Role, User;

        static public void Autorization1 (string login, string password)
        {
            try
            {
                DBconnection.msCommand.CommandText = @"SELECT role_name from role_table , user WHERE username = '" + login + "' and password = '" + password + "' and user.id_role = role_table.id_role ";
                Object result = DBconnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    Role= result.ToString();
                    User = login;
                }
                else 
                {
                    Role= null;
                }
            }
            catch 
            {
                Role = User = null;
                MessageBox.Show("Ошибка при входе");
            }
        }
    }
}
