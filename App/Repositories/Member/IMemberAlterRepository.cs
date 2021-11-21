using System;
using System.Collections.Generic;
using System.Text;

namespace Church.App.Repositories.Member
{
    interface IMemberAlterRepository
    {
        bool AlterMember(int id_member, string name, string gender, int cepaddress, string streetaddress, string neighborhoodadrress, int numberaddress, string complementaddress, string stateaddress, string ufaddress, int dddphone, int numberphone, string office, string memberactiveinchurch, DateTime startmemberdateinchurch);
    }
}
