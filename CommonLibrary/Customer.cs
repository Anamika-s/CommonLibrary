using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    //public class Customer
    //{
    //    EMail email = new EMail();
    //    public bool AddCustomer()
    //    {
    //        // some statments will come here that will add this record in database
    //        bool resp = email.SendMail();  // want to mock this function
    //        return resp;

    //    }
    //}

    //public class EMail()
    //{
    //    public bool SendMail()
    //    {
    //         // some statements will come here to send mail to newly added user
    //         return false;
    //    }
    //}



    public class Customer
    {
       
        public virtual bool AddCustomer(EMail email)
        {
            // some statments will come here that will add this record in database
            bool resp = email.SendMail();  // want to mock this function
            return resp;

        }
    }

    public class EMail()
    {
        public virtual bool SendMail()
        {
            // some statements will come here to send mail to newly added user
            return false;
        }
    }
}
