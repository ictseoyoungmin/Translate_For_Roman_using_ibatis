using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
   
    [Serializable]
    public class Unicode_Table_DTO
    {
        public int Number { get; set; }
        public string Korean { get; set; }
        public string Unicode { get; set; }
        public string Roman { get; set; }
        public string Roman_ex { get; set; }
        public string Last_name { get; set; }

    }

    [Serializable]
    public class Cust_DTO
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
    
}
