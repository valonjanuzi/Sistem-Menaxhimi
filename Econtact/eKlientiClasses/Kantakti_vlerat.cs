using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Econtact.econtactClasses
{
    abstract class Kantakti_vlerat
    {

        //Getter and seter
        public int ContactID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String ContactNo { get; set; }
        public String Address { get; set; }
        public String Gender { get; set; }
    }
}
