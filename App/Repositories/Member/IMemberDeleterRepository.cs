using System;
using System.Collections.Generic;
using System.Text;

namespace Church.App.Repositories.Member
{
    interface IMemberDeleterRepository
    {
        bool InactiveChurch(int id_member);
    }
}
