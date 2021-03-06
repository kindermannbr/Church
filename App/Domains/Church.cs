using System;
using System.Collections.Generic;
using System.Text;

namespace Church.App.Domains
{
    class Church
    {

        public string Name
        { get; set; }
        public string Cnpj
        { get; set; }
        public int CepAddress //fazer integração com viacep, para pegar as informações
        { get; set; }
        public string StreetAddress
        { get; set; }
        public string NeighborhoodAdrress
        { get; set; }
        public int NumberAddress
        { get; set; }
        public string ComplementAddress
        { get; set; }
        public string StateAddress
        { get; set; }
        public string UfAddress
        { get; set; }
        public DateTime InaugurationDate
        { get; set; }
        public string CadasterIsActive //campo que informa se o cadastro da igreja está ativo, ou não, no sistema
        { get; set; }
    }
}
