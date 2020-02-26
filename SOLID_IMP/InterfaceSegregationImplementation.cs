using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_IMP
{
    class InterfaceSegregationImplementation
    {
        public InterfaceSegregationImplementation()
        {
            ClientImp clientImp = new ClientImp();
            clientImp.ReadRecords();
            clientImp.EditRecords();

            Client2Imp clientImp2 = new Client2Imp();
            clientImp2.ReadRecords();

        }
    }

    interface ClientImpOperationsRead
    {
        void ReadRecords();


    }
    interface ClientImpOperationsWrite
    {
        void EditRecords();

    }

    /// <Client>
    /// client want both read & write operations
    /// </Client>
    class ClientImp : ClientImpOperationsRead,ClientImpOperationsWrite
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
    class Client2Imp : ClientImpOperationsRead
    {
        public void ReadRecords()
        {
            Console.WriteLine("Client 2Read Records ");
        }

    }



}
