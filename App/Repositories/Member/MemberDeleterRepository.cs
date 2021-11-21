using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Church.App.Repositories.Member
{
    class MemberDeleterRepository : IMemberDeleterRepository
    {
        public bool DeleteMember(string memberActiveInChurch, int id_member)
        {
            bool success = false;
            //essa classe não irá deletar. Apenas irá alterar o campo memberActiveInChurch, informando que ele não está mais ativo
            using (MySqlConnection mySqlConnection = new MySqlConnection())
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.CommandText = $"update member set memberactiveinchurch='Não'  where id={id_member}";
                int affectedRow = mySqlCommand.ExecuteNonQuery();
                success = affectedRow > 0;
            }

                return success;
        }
    }
}
