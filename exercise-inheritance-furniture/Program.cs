using System;
using System.Dynamic;

namespace exercise_inheritance_furniture
{
   public class Program
    {
        static void Main(string[] args)
        {
            //create an array  of objects in furniture type
            //create program class object
            // call AddToStock(<furniture array>);
            //call ShowStockDetails(<furniture array>);
            // call TotalStockValue(<furniture array>) and display output 
            Furniture[] furnitures = new Furniture[2];
            Program program = new Program();
            program.AddToStock(furnitures);
            program.ShowStockDetails(furnitures);
            Console.WriteLine(program.ShowStockDetails(furnitures));
        }
       public int AddToStock(Furniture []items) {

            //accept the choice from user for type of furniture(BookShelf  or DiningTable)
            // and according to the choice create necessary sub class object and store data
            //continue the process up to the size of array
             
           // return <size of array>;
           for(int i=0;i<items.Length;i++)
            {
                Console.WriteLine("Enter choice of furniture 1 or 2");
                string str = Console.ReadLine();
                switch (str)
                {
                    case "1":
                            items[i] = new BookShelf();
                        break;
                    case "2":
                        items[i] = new DiningTable();
                        break;
                    default:
                        break;
                }
                items[i].Accept();
            }
            return items.Length;
        }
     public   double TotalStockValue(Furniture []items)
        {
            double stockValue=default;
            //calculate total stock value i.e qty * price of each item
            for(int i = 0; i < items.Length; i++)
            {
                stockValue += items[i].Qty * items[i].Price;
            }
            return stockValue;
        }
    public int ShowStockDetails(Furniture[] items)
        {
            //call display method from all object to display the stock 
           //return <size of array>;
           foreach(Furniture x in items) {
                x.Display();
            }return items.Length;
        }
    }
}
