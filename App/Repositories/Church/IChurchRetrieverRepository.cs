using System;
using System.Collections.Generic;
using System.Text;

namespace Church.App.Repositories.Church
{
    interface IChurchRetrieverRepository
    {
        //não irá retornar todas as igrejas, pois somente o Admin do APP, deve ter acesso a todas as igreja.
        //uma igreja não pode ter acesso a dados de outra...
        bool GetSpecificChurch(int id_church);
    }
}
