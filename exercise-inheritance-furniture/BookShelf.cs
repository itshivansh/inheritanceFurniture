
using System;
using System.Collections.Generic;
using System.Text;


namespace exercise_inheritance_furniture
{
    public class BookShelf:Furniture
    {
        public int NoOfShelves { get; set; }
        public override void Accept()
        {
            base.Accept();
            Console.Write("No of shelves");
            NoOfShelves = Convert.ToInt32(Console.ReadLine());
        }
        public override void Display()
        {
            base.Display();
            Console.Write("No of shelves");
            Console.WriteLine("No of Shelves{0}", NoOfShelves);
        }
    }
}

















































/**
* @author Anilkumar.S
*
* @date - 8/24/2020 2:28:32 PM 
*/
