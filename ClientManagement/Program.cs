using System;

namespace ClientManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 1;

            Client client1 = new Client();
            client1.Id = id;
            id++;
            client1.Name = "Mert";
            client1.SurName = "CUMALI";
            client1.AccountBalance = 15000.50;

            Client client2 = new Client();
            client2.Id = id;
            id++;
            client2.Name = "Engin";
            client2.SurName = "DEMİROĞ";
            client2.AccountBalance = 140000.99;


            Client client3 = new Client();
            client3.Id = id;
            id++;
            client3.Name = "Arda";
            client3.SurName = "YILDIZ";
            client3.AccountBalance = 20000;

            ClientManager management = new ClientManager();
            management.AddClient(client1);
            management.AddClient(client2);
            management.AddClient(client3);
            Console.WriteLine();

            Client[] clients = { client1, client2, client3 };
            management.DisplayClients(clients);

            Console.WriteLine();
            management.DeleteClient(client1);
            management.DeleteClient(client2);
            management.DeleteClient(client3);

            Console.WriteLine();
            management.UpdateClientAccount(client1, 50000.50);
            management.UpdateClientAccount(client2, 200000.99);
            management.UpdateClientAccount(client3, 40000);



        }
    }
}
