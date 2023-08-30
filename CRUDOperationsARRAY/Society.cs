using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDOperationsARRAY
{
    public class Society
    {
        public int id;
        public string name; 
        public string wing;

        public Society(int id, string name, string wing)
        {
            this.id = id;
            this.name = name;
            this.wing = wing;
        }
       
        public int Id {get=>id;set=>id=value;}
        public string Sname { get=>name;set=>name=value;}
        public string Wing { get=>wing;set=>wing=value;}

        

        public override string ToString()
        {
            return $"{Id}\t{Sname}\t{Wing}";
        }
    }
}
