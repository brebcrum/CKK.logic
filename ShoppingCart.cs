using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CKK.logic.Models
{
    public class ShoppingCart
    {
        private ShoppingCartItem _product1;
        private ShoppingCartItem _product2;
        private ShoppingCartItem _product3;
        private Customer _customer;

        ////Make sure that the GetCustomerId() returns the same Id as the customer that was put in the argument in the constructor. 
        public ShoppingCartItem(Costumer costumer)
        {
            _customer = costumer; 
        }


        //returns customer id
        public int GetCustomerId()
        {
            return _customer.GetId();
        }


        //Runs other add product method with quantity of 1
        public ShoppingCartItem AddProduct(Product product)
        {
            return AddProduct(product, 1);
        }

        public ShoppingCartItem AddProduct(Product product, int quantity)
        {
            ShoppingCartItem item = new ShoppingCartItem(product, quantity);

            //Checks for valid quantity
            if (quantity < 0)
            {
                return null;
            }
            //Checks for product and adds quantity if found
            if (product.GetId() == _product1.GetProduct().GetId())
            {
                //add quantity to the existing quantity
                //set quantity using teh value passed in and the existing quantity from the product (i.e. getquaantity)
                return product.Getquantity() + quantity;
            }

            //Returns the product changed or null
            //Adds product if new
            if (_product1 == null)
            {
                return _product1;
            }

            if (_product2 == null)
            {
                return _product2;
            }

            if (_product3 == null)
            {
                return _product3;
            }
        }


        //Checks for valid quantity
        //Checks for product and removes quantity if found
        //Returns the product changed or null
        public ShoppingCartItem RemoveProduct(Product product, int quantity)
        {

            //Checks for valid quantity
            if (quantity < 0)
            {
                return null;
            }

            //Checks for product and removes quantity if found
            if (product.GetId() == _product1.GetProduct().GetId())
            {
                return product.Getquantity() - quantity;
            }


            //Returns the product changed or null
            if (_product1 == null)
            {
                return _product1;
            }

            if (_product2 == null)
            {
                return _product2;
            }

            if (_product3 == null)
            {
                return _product3;
            }
        }


        //Returns the product with matching id
        public ShoppingCartItem GetProductById(int id)
        {
            if (_product1.GetId() == id)
            {
                return _product1;
            }
            else if (_product2.GetId() == id)
            {
                return _product2;
            }
            else if (_product3.GetId() == id)
            {
                return _product3;
            }
            else
            {
                return null;
            }
        }


        //returns total of all products
        public decimal GetTotal()
        {
            return GetQuantity() * _product.GetPrice();
        }


        //returns the product in the position of prodNumor null
        public ShoppingCartItem GetProduct(int productNum)
        {
            if (productNum < 0)
            {
                return null;
            }
        }

    }
}
