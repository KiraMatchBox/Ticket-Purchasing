using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    class customer
    {
        public static String name
        {
            get; set;
        }
        public static String email
        {
            get; set;
        }
        public static int age
        {
            get; set;
        }
        public static int lower
        {
            get; set;
        }
        public static int club
        {
            get; set;
        }
        public static int upper
        {
            get; set;
        }
        public static int totalCost
        {
            get; set;
        }
        public static String creditCardNumber
        {
            get; set;
        }
        public static String cardName
        {
            get; set;
        }
        public static int CSV
        {
            get; set;
        }
        public static int confirmationNumber
        {
            get; set;
        }
        //Super Sick recursive function to return confirmation numbers and ensure there aren't any duplicates
        public static int generateConfirmationNumber()
        {
            int min = 1000;
            int max = 9999;
            Random rand = new Random();
            int conNum = rand.Next(min, max);
            Boolean took = false;
            String[] customers = File.ReadAllLines("CustomerData.txt");

            var taken = from line in customers
                        let customerIndex = line.Split(' ')
                        let takenConNum = customerIndex[10]
                        select new { takenConNum };
            foreach (var info in taken)
            {
                if (conNum == int.Parse(info.takenConNum))
                {
                    took = true;
                }
            }
            if (took == true)
            {
                return generateConfirmationNumber();
            }
            else
            {
                return conNum;
            }
        }
        //Function to return price value for every ticket sold
        public static int getTotalSales()
        {
            int total = 0;
            String[] Customers = File.ReadAllLines("CustomerData.txt");
            var sales = from line in Customers
                        let customerIndex = line.Split(' ')
                        let indvSales = customerIndex[9]
                        select new { indvSales };
            foreach(var info in sales)
            {
                total += int.Parse(info.indvSales);
            }
            return total;
        }
        //Returns number of lower level seats remaining
        public static int getLowerLevelRemaining()
        {
            int total = 200;
            String[] Customers = File.ReadAllLines("CustomerData.txt");
            var sold = from line in Customers
                       let customerIndex = line.Split(' ')
                       let saled = customerIndex[6]
                       select new { saled };
            foreach(var info in sold)
            {
                total -= int.Parse(info.saled);
            }
            return total;
        }
        //Returns number of club level seats remaining
        public static int getClubLevelRemaining()
        {
            int total = 75;
            String[] Customers = File.ReadAllLines("CustomerData.txt");
            var sold = from line in Customers
                       let customerIndex = line.Split(' ')
                       let saled = customerIndex[7]
                       select new { saled };
            foreach (var info in sold)
            {
                total -= int.Parse(info.saled);
            }
            return total;
        }
        //Returns number of upper deck seats remaining
        public static int getUpperDeckRemaining()
        {
            int total = 200;
            String[] Customers = File.ReadAllLines("CustomerData.txt");
            var sold = from line in Customers
                       let customerIndex = line.Split(' ')
                       let saled = customerIndex[8]
                       select new { saled };
            foreach (var info in sold)
            {
                total -= int.Parse(info.saled);
            }
            return total;
        }
    }
}
