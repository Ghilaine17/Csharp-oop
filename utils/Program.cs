using System.Collections;
using System.Security.Cryptography;

namespace utils
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Product product1 = new Product("Max Verstappen", "per chi vuole la massima velocità", 1200, 999999, -50);
            Console.WriteLine("Nome prodotto: " + product1.NameProduct);
            Console.WriteLine("Descrizione prodotto: " + product1.DescriptionProduct);
            Console.WriteLine("Prezzo: " + product1.PriceProduct + " euro");
            string priceWithTax = product1.GetPriceWithTax(product1.PriceProduct);
            Console.WriteLine("Prezzo con iva: " + priceWithTax + " euro");
            Console.WriteLine("Numero seriale completo: " + product1.GetCompleteSerialNumber(product1.SerialNumber));
            product1.PrintCompleteName();
            Console.WriteLine("");
            List<Product> productList =
                [
                    new Product("Il Fabbricante di lacrime","Libro per adolescenti con copertina flessibile", 10, 8752,-18),
                    new Product("Pallone da calcio arancione","Marca Santos", -10, 8752, 2),
                    new Product("Orologio","Decorato in ottone", -30, 8752,43)
                ];
            foreach (Product product in productList)
            {
                Console.WriteLine("Nome prodotto: " + product.NameProduct);
                Console.WriteLine("Descrizione prodotto: " + product.DescriptionProduct);
                Console.WriteLine("Prezzo: " + Product.CheckNegativeNumber(product.PriceProduct) + " euro");
                product.GetPriceWithTax(Product.CheckNegativeNumber(product.PriceProduct));
                Console.WriteLine("Prezzo con iva: " + product.GetPriceWithTax(Product.CheckNegativeNumber(product.PriceProduct)) + " euro");
                Console.WriteLine("Numero seriale completo: " + product.GetCompleteSerialNumber(product.SerialNumber));
                product.PrintCompleteName();
                Console.WriteLine("");

            }
        }
    }
    
}
