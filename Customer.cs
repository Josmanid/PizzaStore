using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore
{
    internal class Customer
    {

        #region Instance field
        private string _customerName;
        

        #endregion

        #region Properties
        public string CustomerName 
        { get { return _customerName; } }

       
        #endregion

        #region Constructers
        public Customer(string CustomerName)
        {
            _customerName = CustomerName;
        }
        #endregion
        #region Methods
        public override string ToString() {
            return $"Customer: {CustomerName}";
        }

        #endregion

    }
}
