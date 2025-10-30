using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utils
{
    public class Product
    {
        private int serialNumber;
        public int SerialNumber
        {
            get
            {
                return serialNumber;
            }
            private set
            {
                serialNumber = value;
            }
        }
        public string NameProduct { get; set; }
        public string DescriptionProduct { get; set; }
        public int PriceProduct { get; set; }
        public int Tax { get; set; }

        public Product(string nameProduct, string descriptionProduct, int priceProduct, int maxRandomNumber, int tax)
        {
            this.NameProduct = nameProduct;
            this.DescriptionProduct = descriptionProduct;
            this.PriceProduct = priceProduct;
            this.SerialNumber = RandomNumberGenerator(maxRandomNumber);
            this.Tax = tax;
        }
        private static int RandomNumberGenerator(int maxRandomNumber)
        {
            return new Random().Next(1, maxRandomNumber);
        }

        public string GetPriceWithTax(int price)
        {
            Tax = CheckNegativeNumber(Tax);
            float priceWithTax = (price * ((float)Tax / 100)) + price;
            return priceWithTax.ToString("0.00");
        }

        public string GetCompleteSerialNumber(int serialNumber)
        {
            char pad = '0';
            string result = serialNumber.ToString().PadLeft(8, pad);
            return result;
        }

        public void PrintCompleteName()
        {
            Console.WriteLine("Codice identificativo: "+ GetCompleteSerialNumber(SerialNumber) +"-"+ NameProduct);
        }
        public static int CheckNegativeNumber(int num)
        {
            if (num < 0)
            {
                Console.WriteLine("Hai inserito un numero negativo!");
                return Math.Abs(num);
            }
            return num;
        } 
    }
}
