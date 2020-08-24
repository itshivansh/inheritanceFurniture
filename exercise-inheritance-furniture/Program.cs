using System;

namespace exercise_inheritance_furniture
{
   public class Program
    {
        static void Main(string[] args)
        {
            Furniture[] f = new Furniture[2];
            Program p = new Program();
            p.AddToStock(f);
            p.ShowStockDetails(f);
           Console.WriteLine("Total Stock Value:  "+ p.TotalStockValue(f));
            
        }
       public int AddToStock(Furniture []items) {
            int choice ;
            int i = 0;
            do
            {
                Console.WriteLine("Enter your choice 1-DiningTable,2-BookShelf");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        items[i] = new DinigTable();  //f[0]
                        items[i].Accept();                 
                        break;
                    case 2:
                        items[i] = new BookShelf(); //f[1]                                           
                        items[i].Accept();  //
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
                i++;

            } while (i < items.Length);
            return i;
        }
     public   double TotalStockValue(Furniture []items)
        {
            double stockValue=default;
            foreach(Furniture f in items)
            {
                stockValue +=   f.Price * f.Qty;
            }
            return stockValue;
        }
    public    int ShowStockDetails(Furniture[] items)
        {
            foreach (Furniture f in items)
            {
                f.Display();
            }
           return items.Length;
        }
    }
}
