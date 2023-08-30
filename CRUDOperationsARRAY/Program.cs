using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDOperationsARRAY
{
    public class Program
    {
        static void Main(string[] args)
        {
            int no = 0;
            SocietyImplementation si= new SocietyImplementation();
           
            do
            {
                Console.WriteLine("1.Show All Society Records");
                Console.WriteLine("2.Add Record");
                Console.WriteLine("3.Search Record By Society ID");
                Console.WriteLine("4.Update Record");
                Console.WriteLine("5.Delete record");
                int choice=Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        si.ShowDetails();
                        break;
                    case 2:
                        Console.WriteLine("How Many Records Do you want to Add");
                        int n=Convert.ToInt32(Console.ReadLine());
                        si.AddDetails(n);
                        break;
                    case 3:
                        Console.WriteLine("Enter Society ID you want to search");
                        int id=Convert.ToInt32(Console.ReadLine());
                        si.Searchsocietybyid(id);

                        break;
                    case 4:
                        Console.WriteLine("Enter Society ID you want to Update");
                        int id1=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter New Wing");
                        string wing=Console.ReadLine();
                        si.UpdateSocietyRecord(id1,wing);
                        Console.WriteLine("Record Updated");
                        break;
                    case 5:
                        Console.WriteLine("Enter Id you want to delete");
                        int id3=Convert.ToInt32(Console.ReadLine());
                        si.DeleteRecord(id3);
                        Console.WriteLine("Record Deleted");
                        break;
                }
                Console.WriteLine("Press 1 To Continue");
                no=Convert.ToInt32(Console.ReadLine());

            } while(no==1);
        }
    }
}
