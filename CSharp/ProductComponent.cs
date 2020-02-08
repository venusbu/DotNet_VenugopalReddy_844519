using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProductComponent
{
    public class Product
    {
        public int ProID { get; set; }
        public string ProName { get; set; }
        public int ProPrice { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine("ProductId = {0}, ProductName = {1}, ProductPrice = {2}", ProID, ProName, ProPrice);
        }
   

    }
}
