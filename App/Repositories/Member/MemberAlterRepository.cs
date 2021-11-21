using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Church.App.Repositories.Member
{
    class MemberAlterRepository : IMemberAlterRepository
    {
        public bool AlterMember(int id_member, string name, string gender, int cepaddress, string streetaddress, string neighborhoodadrress, int numberaddress, string complementaddress, string stateaddress, string ufaddress, int dddphone, int numberphone, string office, string memberactiveinchurch, DateTime startmemberdateinchurch)
        {
            bool success = false;

            using (MySqlConnection mySqlConnection = new MySqlConnection())
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.CommandText = $"update member set name='{name}', gender='{gender}', cepaddress={cepaddress}, streetaddress='{streetaddress}', neighborhoodadrress='{neighborhoodadrress}', numberaddress={numberaddress}, complementaddress='{complementaddress}', ufaddress='{ufaddress}', dddphone={dddphone}, numberphone={numberphone}, office='{office}', memberactiveinchurch='{memberactiveinchurch}', startmemberdateinchurch='{startmemberdateinchurch}' where id={id_member}";
                int affectedRows = mySqlCommand.ExecuteNonQuery();

                success = affectedRows > 0;
            }

            return success;
        }
    }
}
