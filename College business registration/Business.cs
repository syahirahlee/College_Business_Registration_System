using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_business_registration
{
    class Business
    {
        //declare attributes for Business class
        private int _days, _fee, _month;
        private string _type, _statusapprov;
       
         public int Days
        {
            get
            {
                return _days;
            }

            set
            {
                _days = value;
            }
        }

        public int Fee
        {
            get
            {
                return _fee;
            }

            set
            {
                _fee = value;
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        public string Statusapprov
        {
            get
            {
                return _statusapprov;
            }

            set
            {
                _statusapprov = value;
            }
        }

        public int Month
        {
            get
            {
                return _month;
            }

            set
            {
                _month = value;
            }
        }


        //default constructor
        public Business()
        {
            
        }

        //method to calculate registration fee based on business type chosen
        public int CalculateFee()
        {
            int total = 0;
            if (_type == "Kiosk") //for kiosk business
            {
                total = 80 * _month;
            }
            else if (_type == "Daily") //for daily business
            {
                total = 10 * _days;
            }
            else  //mobile business
            {
                total = 40;
            }

            return total;
        }
    }
}
