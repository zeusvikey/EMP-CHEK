using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsProject1
{
    internal class TestCustomers
    {
        static void Main(string[] args)
        
        {
            Customers obj = new Customers(1000);
            Console.WriteLine("Custid:" + obj.Custid);

            //if (obj.Status)
            //{
            //    Console.WriteLine("Customers Staus : Active");
            //}
            //else
            //{
            //    Console.WriteLine("Customer Status: In-Active");
            //    Console.WriteLine("Customer Name: " + obj.Name + "\n ");
            //}
            obj.Status = true;
            if (obj.Status)
                Console.WriteLine("Customer Status: Active");
            else
                Console.WriteLine("Customer Status: In-Active\n");
            Console.WriteLine("Customer Name: " + obj.Name + "\n ");

            //HERE CONDINTION FOR UPDATE:=>>
            Console.WriteLine("IF YOU WANT TO UPDATE THEN PRESS Y AND ENTER OR PRESS N FOR NOTHING UPDATED:");
            string input = Console.ReadLine();
            if (input.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                if (obj.Status)
                {
                    Console.WriteLine("Enter the value to update the Name:");
                    string a = Console.ReadLine();
                    obj.Name += a;

                    // Console.WriteLine("Name when update succeeded: " + obj.Name + "\n");
                    //Console.WriteLine("Balance when status is active: " + obj.Balenced + "\n"); 
                }
                else
                {
                    Console.WriteLine("Status is inactive. Cannot update.");
                }
            }
            else
            {
                Console.WriteLine("Nothing updated.");
                Console.WriteLine("Customer Status: In-Active");
                Console.WriteLine("Customer Name: " + obj.Name);
                Console.WriteLine("Name when update succeded: " + obj.Name);
                Console.WriteLine("Balance when status is active: " + obj.Balenced + "\n");
                return;
            }




            if (obj.Balenced <= 4600)
            { //Transaction failed
                Console.WriteLine("Balance  transaction failed: " + obj.Balenced);
            }
            else if (obj.Balenced >= 4500)
            {
                Console.WriteLine("Balance  transaction succeded: " + obj.Balenced + "\n");
            }
               
            obj.Status = true; //Activating the status
            if (obj.Status)
                Console.WriteLine("Customer Status: Active");
            else
                Console.WriteLine("Customer Status: In-Active"+ "\n");
            Console.WriteLine("Customer Name: " + obj.Name);
            Console.WriteLine("Name when update succeded: " + obj.Name);
            Console.WriteLine("Balance when status is active: " + obj.Balenced);
            Console.WriteLine("State Name: " + obj.State);
            Console.WriteLine("City Name: " + obj.City);
            Console.WriteLine("Country Name: " + obj.Country);










        }
    }
}


//Console.WriteLine("IF YOU WANT TO UPDATE THEN UPDATE then PRESS ENTER Y:");
//if (obj.Status = y)
//{
//    if (obj.Status)
//    {

//        string a = Console.ReadLine();
//        obj.Name += a;

//        Console.WriteLine("Name when update succeeded: " + obj.Name + "\n");
//        Console.WriteLine("Balance when status is active: " + obj.Balenced + "\n");
//    }
//}
//else
//{
//    Console.WriteLine("Nothing update");
//    return;
//}  write the clean code 