using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Order
    {

        #region Instance field
        private double _taxPct;
        private double _deliveryCosts;
        Pizza _p;
        Customer _c;

        #endregion

        #region Properties
        public double TaxPct 
        { 
            get 
            {  return _taxPct; } 
            set 
            { _taxPct = value; }
        }

        public double DeliveryCosts
        {
            get 
            { return _deliveryCosts; }
            set 
            { _deliveryCosts = value; }
        }

        public Customer Customer
        {
            get
            {return _c;}
            set
            {_c = value;}

        }
        public Pizza Pizza {
            get
            {return _p;}
            set 
            {_p = value;} 
        
        }
        #endregion

        #region Constructers
        public Order(Pizza pizza, Customer customer)
        {
            _p = pizza;
            _c = customer;
            TaxPct = 5;
            DeliveryCosts = 35;
            
        }
        #endregion
        #region Methods
        public double CalculateTotalPrice() 
        {
            double totalPrice = _p.Price+DeliveryCosts+TaxPct;
            return totalPrice;

        }
        public override string ToString() {
            return $"{Pizza} | {Customer} | Total Price: {CalculateTotalPrice()} kr";
        }
        #endregion

    }
}
