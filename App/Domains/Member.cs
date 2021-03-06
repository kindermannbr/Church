using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Church.App.Domains
{
    class Member
    {

        public string Name
        { get; set; }
        public string Gender //incluir "Outros"
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
        public int DddPhone
        { get; set; }
        public int NumberPhone
        { get; set; }
        public DateTime StartMemberDateinChurch //data que o membro iniciou na igreja . Não obrigatório
        { get; set; }
        public DateTime BaptismDate //não obrigatório
        { get; set; }
        public string MemberActiveInChurch
        { get; set; }
        public DateTime Birthdate
        { get; set;  }
    }
}
