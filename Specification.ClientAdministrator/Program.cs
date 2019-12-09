using Specification.ClientAdministrator.Models;
using Specification.ClientAdministrator.Models.Specifications;
using Specification.ClientAdministrator.Repository;
using System;

namespace Specification.ClientAdministrator
{
    class Program
    {
        static void Main(string[] args)
        {
            var clientRepository = new ClientRepository();

            #region Get Client By Name
            Console.WriteLine("==============================================");
            Console.WriteLine("Client By Name\n");

            GetClientByName(clientRepository);

            Console.WriteLine("==============================================\n");
            #endregion

            #region Get Client By Min Age
            Console.WriteLine("==============================================");
            Console.WriteLine("Client By Min Age \n");
            GetClientByMinAge(clientRepository);

            Console.WriteLine("==============================================\n");
            #endregion

            Console.ReadLine();
        }

        private static void GetClientByName(ClientRepository clientRepository)
        {
            var clients = clientRepository.GetClientBy(new ClientNameSpecification("a"));

            foreach (var client in clients)
            {
                Console.WriteLine($"Client with Id {client.ClientId}, Name {client.Name} {client.LastName} and Join Date {client.JoinDate.ToShortDateString()}");
            }
        }

        private static void GetClientByMinAge(ClientRepository clientRepository)
        {
            var clients = clientRepository.GetClientBy(new ClientMinAgeSpecification());

            foreach (var client in clients)
            {
                Console.WriteLine($"Client with Id {client.ClientId}, Name {client.Name} {client.LastName} and Age {client.Age}");
            }
        }
    }
}
