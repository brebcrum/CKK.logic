using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreys_knick_knacks
{
    internal class Customer
    {
        private int id;
        private string name;
        private string address;

        public int Id
        {

            set { id = value; }
            get { return id; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Address
        {
            set { address = value; }
            get { return address; }
        }
    }
}
