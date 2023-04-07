using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Product
    {
        public int Code{ get; private set; }
        public string? Name{ get; set; }
        public string? Description{ get; set; }
        public decimal Price{ get; set; }
        public int Vat{ get; set; }

        public Product(string name = "", string description = "", decimal price = 0, int vat = 22)
        {
            Code = new Random().Next(1, 999999);
            Name = name;
            Description = description;
            Price = price;
            Vat = vat;
        }

        public string GetCodeWithPadLeft()
        {
            return Code.ToString().PadLeft(8, '0');
        }

        public decimal PriceVatIncluded()
        {
            return Decimal.Round(((Price / 100) * Vat) + Price, 2);
        }

        public string ExtendedName()
        {
            return GetCodeWithPadLeft() + " " + Name;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Codice e Nome: {ExtendedName()}");
            Console.WriteLine($"Descrizione: {Description}");
            Console.WriteLine($"Prezzo con iva: {PriceVatIncluded()}");
            Console.WriteLine($"Prezzo senza iva: {Price}");
            Console.WriteLine($"Iva: {Vat}%\r\n");
        }
    }
}
