using System;
using System.Collections.Generic;
using System.Text;

/*
  "cep": "01001-000",
  "logradouro": "Praça da Sé",
  "complemento": "lado ímpar",
  "bairro": "Sé",
  "localidade": "São Paulo",
  "uf": "SP",
  "ibge": "3550308",
  "gia": "1004",
  "ddd": "11",
  "siafi": "7107"
*/

namespace Church.App.Domains
{
    class Address
    {
        public string Cep
        { get; set; }
        public string Logradouro
        { get; set; }
        public string Complemento
        { get; set; }
        public string Bairro
        { get; set; }
        public string Localidade
        { get; set; }
        public string Uf
        { get; set; }
        public string Ibge
        { get; set; }
        public string Gia
        { get; set; }
        public string Ddd
        { get; set; }
        public string Siafi
        { get; set; }
    }
}
