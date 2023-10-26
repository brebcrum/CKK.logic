using System.Security.Cryptography.X509Certificates;
using Xunit.Sdk;

namespace CKK.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
          
          
            //get product
            try
            {
                ShoppingCart shoppingcart = new ShoppingCart();
                int exepect = 12345;

                ////assemble??
                shoppingcart.product1.GetProduct.GetId(exepect);
                int actual = shoppingcart.product1.GetProduct.GetId();

                int total = shoppingcart.product3.GetTotal();

                Assert.Equal(exepect, actual);


            }
            catch
            {
                throw new XunitException("invalid ID");
            }
        }


    }
}