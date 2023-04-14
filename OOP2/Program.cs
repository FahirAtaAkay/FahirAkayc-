using System;

namespace OOP2 
{
    class Program
    {
        static void Main(string[] args)
        {
            RealClient client1 = new RealClient();
            client1.Name = "Test";
            client1.ClientId = 1515;
            
            CompanyClient companyClient1 = new CompanyClient();
            companyClient1.TaxCode = "121213";
            companyClient1.CompanyName = "SpaceZ";

            //client1.ClientName = "test";
            //client1.Surname = "test";
            //client1.ClientId = 12345;
            //client1.ClientNo = "12345";

            //tüzel değil sirket adi yok ne yapacaz
            //SOLID L 

            Client client3 = new RealClient();
            Client client4 = new CompanyClient();
            Client client5 = new Client();
            //ikisinin de referansını tutabilen bir musteri classımız oldu

            ClientManager clientManager = new ClientManager();
            clientManager.Add(client1);
            //tüm muzterileri inheritaence sayesinde ekleyebildim. base classın mirasını alan diğer classların referansını tutabildiği için bu imkana sahip olduk







        }
    }
}
