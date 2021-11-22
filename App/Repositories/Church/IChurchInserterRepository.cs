﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Church.App.Repositories.Church
{
    interface IChurchInserterRepository
    {
        bool InsertChurch(string name, string cnpj, int cepAddress, string streetAddress, string neighborhoodAdrress, int numberAddress, string stateAddress, string ufAddress, DateTime inaugurationDate, string cadasterIsActive, string complementAddress);
    }
}
