using Specification.ClientAdministrator.Models;
using Specification.ClientAdministrator.Repository;
using System;

namespace Specification.ClientAdministrator
{
    class Program
    {
        static void Main(string[] args)
        {
            var clientRepository = new ClientRepository();

            #region Get Client By Id
            Console.WriteLine("==============================================");
            Console.WriteLine("Client By Id \n");
            GetClientById(clientRepository);

            Console.WriteLine("==============================================\n");
            #endregion

            #region Get Client By Name
            Console.WriteLine("==============================================");
            Console.WriteLine("Client By Name\n");

            GetClientByName(clientRepository);

            Console.WriteLine("==============================================\n");
            #endregion

            #region Validate Client For Discount
            Console.WriteLine("==============================================");
            Console.WriteLine("Check if valid for discount\n");

            var clientNotValid = clientRepository.GetClientById(5);
            Console.WriteLine($"The client with Id {clientNotValid.ClientId} is {(IsValidClientForDiscount(clientNotValid) ? "valid" : "not valid")} for discount");

            var clientValid = clientRepository.GetClientById(3);
            Console.WriteLine($"The client with Id {clientValid.ClientId} is {(IsValidClientForDiscount(clientValid) ? "valid" : "not valid")} for discount");

            Console.WriteLine("==============================================\n");
            #endregion

            Console.ReadLine();
        }

        private static void GetClientByName(ClientRepository clientRepository)
        {
            var clients = clientRepository.GetClientByName("a");

            foreach (var client in clients)
            {
                Console.WriteLine($"Client with Id {client.ClientId}, Name {client.Name} {client.LastName} and Join Date {client.JoinDate.ToShortDateString()}");
            }
        }

        private static void GetClientById(ClientRepository clientRepository)
        {
            var client = clientRepository.GetClientById(1);

            Console.WriteLine($"Client with Id 1 and name {client.Name} {client.LastName} ");
        }

        // Talk about the responsibility of this class and this validation shouldn't be here
        private static bool IsValidClientForDiscount(Client client)
        {
            return client.JoinDate < DateTime.Now.AddDays(-30) && client.Age > 25;
        }
    }
}
