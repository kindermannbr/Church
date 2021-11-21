using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Church.App.Repositories.Address
{
    interface IAddressFinderRepository
    {
        Task FindAddress(string cep);
    }
}
