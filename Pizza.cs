using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Pizza
    {

        #region Instance field
        private string _pizzaName;
        private int _price;

        #endregion

        #region Properties
        public string PizzaName { 
            get { return _pizzaName; }
        }

        public int Price { 
            get { return _price; } 
            set {  _price = value; } 
        }
        #endregion

        #region Constructers
        public Pizza(string name, int price)
        {
            _pizzaName = name;
            _price = price;
        }
        #endregion
        #region Methods
        public override string ToString() 
        {
            return $"Name: {PizzaName} - Price: {Price}";


        }
        #endregion

    }
}
