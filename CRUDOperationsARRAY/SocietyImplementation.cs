using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDOperationsARRAY
{
    internal class SocietyImplementation
    {
         Society[] sarray;
        int cnt;

        public SocietyImplementation()
        {
            sarray= new Society[5];
            cnt=0;
        }

        public void ShowDetails()
        {
           for(int i=0;i<cnt;i++) 
            {
                if (sarray[i]!=null)
                {
                    Console.WriteLine(sarray[i]);
                }

            }
        }

        public void AddDetails(int n)
        {
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Society ID");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Society Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Wing");
                string wing = Console.ReadLine();
                sarray[cnt] = new Society(id, name, wing);
                cnt++;
            }
            
            
        }

        public void Searchsocietybyid(int id)
        {
            for(int i=0;i< cnt;i++)
            {
                if (sarray[i]!=null)
                {
                    if (sarray[i].id==id)
                    {
                        Console.WriteLine(sarray[i]);
                        break;
                    }
                }
            }

        }

        public void UpdateSocietyRecord(int id,string wing)
        {
            for(int i=0;i<cnt;i++)
            {
                if (sarray[i]!=null)
                {
                    if (sarray[i].id==id)
                    {
                        sarray[i].wing = wing;
                    }
                }
            }
        }

        public void DeleteRecord(int id)
        {
            if (id != 0)
            {
                for (int i = 0; i < cnt; i++)
                {
                    if (sarray[i].Id==id)
                    {
                        sarray[i]= null;
                    }

                }
            }
        }



    }
}
