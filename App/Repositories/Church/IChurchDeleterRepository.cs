using System;
using System.Collections.Generic;
using System.Text;

namespace Church.App.Repositories.Church
{
    interface IChurchDeleterRepository
    {
        bool InactiveChurch(int id_church);
        //não irá deletar, apenas inativar

        //string cadasterIsActive = Inativa
    }
}
