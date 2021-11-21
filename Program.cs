using Church.App.Repositories.Address;
using System;

namespace Church
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressFinderRepository addressFinderRepository = new AddressFinderRepository();

            Console.WriteLine("Digite seu CEP");
            string cep = Console.ReadLine();
            addressFinderRepository.FindAddress(cep).Wait();
        }
    }
}
