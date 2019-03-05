using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxsPizzaShop
{
    class Customer
    {
        private string CustName; //CustName = Customer Name
        public string CustNameProp
        {
            get
            {
                return CustName;
            }
            set
            {
                CustName = value;
            }
        }
        
        private string CustPhone; //CustPhone = Customer Phone Number
        public string CustPhoneProp
        {
            get
            {
                return CustPhone;
            }
            set
            {
                CustPhone = value;
            }
        }

        private string CustAddr1; //CustAddr1 = Customer Address line 1
        public string CustAddr1Prop
        {
            get
            {
                return CustAddr1;
            }
            set
            {
                CustAddr1 = value;
            }
        }

        private string CustAddr2; //CustAddr2 = Customer Address line 2
        public string CustAddr2Prop
        {
            get
            {
                return CustAddr2;
            }
            set
            {
                CustAddr2 = value;
            }
        }

        private string CustCity; //CustCity= Customer City
        public string CustCityProp
        {
            get
            {
                return CustCity;
            }
            set
            {
                CustCity = value;
            }
        }

        private string CustState; //CustState = Customer US State
        public string CustStateProp
        {
            get
            {
                return CustState;
            }
            set
            {
                CustState = value;
            }
        }

        private string CustZip; //CustZip = Customer Zip code
        public string CustZipProp
        {
            get
            {
                return CustZip;
            }
            set
            {
                CustZip = value;
            }
        }

        public Customer(string namo, string phono, string addr1, string addr2, string cito, string stato, string zipo) //Customer class constructor, with everything
        {
            CustName = namo;
            CustPhone = phono;
            CustAddr1 = addr1;
            CustAddr2 = addr2;
            CustCity = cito;
            CustState = stato;
            CustZip = zipo;
        }
    }
}
