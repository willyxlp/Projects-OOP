using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profit_calculator
{
    class Product
    {
        public string name;
        public int quantity;
        public double price;
        public double profit;
        private string id;

        public Product(string name, int quantity, double price, double profit)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.profit = profit;
            this.id = GenerateId();

        }

        private string GenerateId()
        {
            Random rnd = new Random();
            int rand = rnd.Next(100000, 999999);
            return $"{name[0]}{name[1]}_{rand}";
        }
        public string GetId()
        {
            id = GenerateId();
            return id ;
        }
        private string GenerateSUM()
        {
            double sum = quantity * price;
            return sum.ToString() ;

        }
        public string GetSum()
        {
          string sum1 = GenerateSUM();
            return sum1;
        }
        private string GenerateProfit()
        {
            double sum = quantity * price;
            double prof = (profit / 100) * sum ;
            return prof.ToString() ;
        }
        public string GetProfit()
        {
            string prof = GenerateProfit();
            return prof ;
        }




    }
     




}

