using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_business_registration
{
    class Student
    {
        //declare attributes of Student class
        private string _studname, _studID, _course, _productType, _telno;
        
        public string Course
        {
            get
            {
                return _course;
            }

            set
            {
                _course = value;
            }
        }

        public string ProductType
        {
            get
            {
                return _productType;
            }

            set
            {
                _productType = value;
            }
        }

        public string StudID
        {
            get
            {
                return _studID;
            }

            set
            {
                _studID = value;
            }
        }

        public string Studname
        {
            get
            {
                return _studname;
            }

            set
            {
                _studname = value;
            }
        }

        public string Telno
        {
            get
            {
                return _telno;
            }

            set
            {
                _telno = value;
            }
        }
    
        public Business Mybusiness
        {
            get
            {
                return mybusiness;
            }

            set
            {
                mybusiness = value;
            }
        }

        //declare object of class Business
        private Business mybusiness;
        
        //default constructor
        public Student()
        {

        }

        public void RegisterNew (Business biz)
        {
            mybusiness = biz;
        }


        //method to get fee value from calculate fee method in business class
        public int getTotalFee()
        {
            int result = mybusiness.CalculateFee();
            return result;
            
        }
        

    }
}
