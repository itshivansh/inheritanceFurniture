
using System;
using System.Collections.Generic;
using System.Text;


namespace exercise_inheritance_furniture
{
   public class DiningTable:Furniture
    {
        public int NoOfLegs { get; set; }
        public override void Accept()
        {
            base.Accept();
            Console.Write("No of Legs");
            NoOfLegs = Convert.ToInt32(Console.ReadLine());
        }
        public override void Display()
        {
            base.Display();
            Console.Write("No of Legs");
            Console.WriteLine("No of Legs:{0}", NoOfLegs);
        }
    }
}


















































/**
* @author Anilkumar.S
*
* @date - 8/24/2020 2:27:28 PM 
*/
