using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_IMP
{
    class InterfaceSegregationViolation
    {

        public InterfaceSegregationViolation()
        {
            Client client = new Client();
            client.ReadRecords();
            client.EditRecords();

            Client2 client2 = new Client2();
            client.ReadRecords();
            client.EditRecords();
        }

    }
    interface ClientOperations
    {
        void ReadRecords();
        void EditRecords();


    }

    /// <Client>
    /// client want both read & write operations
    /// </Client>
    class Client :ClientOperations
    {
        public void ReadRecords()
        {
            Console.WriteLine("Client Read Records ");

        }
        public void EditRecords()
        {
            Console.WriteLine("Client Write Records ");

        }
    }

    /// <Client>
    /// Client want both read operations
    /// </Client>
    class Client2 : ClientOperations
    {
        public void ReadRecords()
        {
            Console.WriteLine("Client 2Read Records ");
        }
        public void EditRecords()
        {
            throw new Exception();
        }
    }


}
