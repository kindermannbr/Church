using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Church.App.Repositories.Church
{
    class ChurchDeleterRepository : IChurchDeleterRepository
    {
        public bool InactiveChurch(int id_church)
        {
            bool success = false;

            using (MySqlConnection mySqlConnection = new MySqlConnection(/*conexão com o banco*/))
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.CommandText = $"UPDATE church SET cadasterisactive = 'Inativo' WHERE id = {id_church}";
                int affectedRows = mySqlCommand.ExecuteNonQuery();
                success = affectedRows > 0;
            }
            return success;
        }
    }
}
