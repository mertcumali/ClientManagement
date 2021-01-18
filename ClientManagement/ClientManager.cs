using System;
using System.Collections.Generic;
using System.Text;

namespace ClientManagement
{
    public class ClientManager
    {
        public void AddClient(Client client)
        {

            Console.Write("The Client: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(client.Name + " " + client.SurName);
            Console.ResetColor();
            Console.WriteLine(" Is Added.");

        }
        public void DeleteClient(Client client)
        {
            Console.Write("The Client: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(client.Name + " " + client.SurName);
            Console.ResetColor();
            Console.WriteLine(" Is Deleted.");
        }
        public void UpdateClientAccount(Client client, double NewBalance)
        {
            Console.Write("The Client: " + client.Name + " " + client.SurName + " Account Balance Is Updated From: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(client.AccountBalance);
            Console.ResetColor();
            Console.Write(" To: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(NewBalance);
            Console.ResetColor();
        }

        public void DisplayClients(Client[] clients)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("-------CLIENT LIST-------");


            foreach (Client client in clients)
            {

                Console.WriteLine("Id: " + client.Id + " Name: " + client.Name + " Surname: " + client.SurName + " Account Balance: " + client.AccountBalance);

            }


            Console.WriteLine("-------------------------");
            Console.ResetColor();
        }

    }
}
