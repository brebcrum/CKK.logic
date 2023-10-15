using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.logic.Models
{
    public class Store
    {
        private int _id;
        private string _name;
        private Product _product1;
        private Product _product2;
        private Product _product3;

        public int GetId()
        {
            return _id;
        }

        public void SetId(int id)
        {
            _id = id;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public Product GetProduct1()
        {
            return _product1;
        }
        public void SetProduct1(Product product1)
        {
            _product1 = product1;
        }

        public Product GetProduct2()
        {
            return _product2;
        }

        public void SetProduct2(Product product2)
        {
            _product1 = product2;
        }
        public Product GetProduct3()
        {
            return _product3;
        }

        public void SetProduct3(Product product3)
        {
            _product3 = product3;
        }

        public void AddStoreItem(Product prod)
        {
            if (_product1  == null)
            {
                _product1 = prod;
            }
            else if (_product2 == null)
            {
                _product2 = prod;
            }
            else if (_product3 == null)
            {
                _product3 = prod;
            }
        }

     
        //this is where I need help..
        public void RemoveStoreItem(Product prod)
        {
            if (_product1 == null)
            {

            }
        }

        public void GetStoreItem()
        {

        }

        public void FindStoreItem(Product prod)
        {

        }
    }
}
