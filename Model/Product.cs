using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProductAppVersion2.Model
{
    internal class Product
    {
        private int _id;
        private string _name;
        private int _price;
        private double _discount = 10.0;
        private double _discountAmount;
        private double _finalPrice;


        public int Id
        {
            get { return _id; }
            set { _id = Id; }
        }
        public int Price
        {
            get { return _price; }
            private set { _price = value > 0 ? value : 0; }
        }
        public string Name
        { get { return _name; } 
          set {  _name = value; } 
        }
        public double Discount
        {
            get { return _discount; }
            private set { _discount = value >= 0 && value <= 100 ? value : 0; }
        }

       
       
        public Product(int productId, string productName, int price)
        {
            _id = productId;
            _name = productName;
            _price = price;
            
            CalculateDisscount(price, _discount);

        }
        public Product(int productId, string productName, int price, double discount) : this(productId, productName, price)
        {

            this._discount = discount;
            CalculateDisscount(price, discount);

        }
        private void CalculateDisscount(int price, double discount)
        {

            _discountAmount = price * (discount / 100);
            _finalPrice = price - _discountAmount;

        }
        public string TotalPrice()
        {
           
            Console.WriteLine($"Disscount for product : {_discount}% ");
            return $"id : {_id}   Name : {_name}  Actual price :{_price} Discount Amount : {_finalPrice}";
        }


    }
}
