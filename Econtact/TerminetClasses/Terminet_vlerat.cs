using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Econtact.TerminetClasses
{
    abstract class Terminet_vlerat
    {

        //Getter and seter
        public int Terminet_ID { get; set; }
        public String Emri_tr { get; set; }
        public String Mbiemri_tr { get; set; }
        public String Numri_tr { get; set; }
        public String Data_tr { get; set; }
        public String Koha_tr { get; set; }

   
    }
}
