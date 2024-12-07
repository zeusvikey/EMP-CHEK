using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsProject1
{
   
    public class Customers
    {
        int _Custid;
        bool _Status;
        string _Name, _State, _Country;
        double _Balenced;
        cities _City;
        public Customers(int Custid) {
            Console.WriteLine("!!!!!!!!!!!WELCOME TO THE CUSTM BANK!!!!!!!!!!!\n");
            int _Custid = Custid;
            _Status = false;
            Console.WriteLine("Enter your Name");
            _Name = Console.ReadLine();
            Console.WriteLine("Enter your Balenced");
            _Balenced = double.Parse(Console.ReadLine());
            _City = cities.Bangalore;
            _State = "Karnataka";
            _Country = "india";
             }
      
        public int Custid {
            get { return _Custid; }
            
        }
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public string Name
        {
            get { return _Name; }
            set
            {
                if (_Status)
                {
                    _Name = value;
                }
            }
        }
        public double Balenced
        {
            get
            {
                if(_Status)
                {
                    return _Balenced;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if (_Status)
                {
                    if (_Balenced > 500)
                    {
                        _Balenced = value;
                    }
                }
            }
        }
        
        public string State
        {
            get { return _State; }

            protected set
            {
                if(_Status)
                {
                    _State = value;
                }
            }
        }
        public cities City
        {
            get { return _City; }
            set
            {
                if (_Status)
                {
                    _City = value;
                }
            }
        }
        public string Country
        {
            get;
            private set;
        }
        public string Continent { get; } = "Asia";
    



}
}
