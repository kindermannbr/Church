using Church.App.Repositories.Address;
using System;

namespace Church
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressRetrieverRepository addressFinderRepository = new AddressRetrieverRepository();

            Console.WriteLine("Digite seu CEP");
            string cep = Console.ReadLine();
            addressFinderRepository.FindAddress(cep).Wait();
        }
    }
}
