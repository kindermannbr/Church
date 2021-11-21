using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Church.App.Repositories.Member
{
    class MemberInserterRepository : IMemberInserterRepository
    {
        public bool InsertMember(string name, string gender, int cepaddress, string streetaddress, string neighborhoodadrress, int numberaddress, string complementaddress, string stateaddress, string ufaddress, int dddphone, int numberphone, string office, string memberactiveinchurch, DateTime startmemberdateinchurch, DateTime birthdate)
        {
            bool success = false;

            //office será passado agora???
            using (MySqlConnection mySqlConnection = new MySqlConnection())
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.CommandText = $"insert into member (name, gender, cepaddress, streetaddress, neighborhoodadrress, numberaddress, complementaddress, stateaddress, ufaddress, dddphone, numberphone, startmemberdateinchurch, memberactiveinchurch, birthdate) values ('{name}', '{gender}', {cepaddress}, '{streetaddress}', '{neighborhoodadrress}', {numberaddress}, '{complementaddress}', '{stateaddress}', '{ufaddress}', {dddphone}, {numberphone}, '{startmemberdateinchurch}', '{memberactiveinchurch}', '{birthdate}')";
                int affectedRows = mySqlCommand.ExecuteNonQuery();

                success = affectedRows > 0;
            }

            return success;
        }
    }
}
