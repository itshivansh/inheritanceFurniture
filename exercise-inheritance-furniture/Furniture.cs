
using System;
using System.Collections.Generic;
using System.Text;
namespace exercise_inheritance_furniture
{
   public class Furniture
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
        public virtual void Accept()
        {
            //code to accept height,width and color
            Console.Write("Height:");
            Height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Width:");
            Width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Color:");
            Color = Console.ReadLine();
            Console.Write("Price:");
            Price = Double.Parse(Console.ReadLine());
            Console.Write("Qty:");
            Qty = Int32.Parse(Console.ReadLine());
        }
        public virtual void Display()
        {
            //code to display height width and color
            Console.Write("Height:");
            Console.WriteLine(Height);
            Console.Write("Width:");
            Console.WriteLine(Width);
            Console.Write("Color:");
            Console.WriteLine(Color);
            Console.Write("Price:");
            Console.WriteLine(Price);
            Console.Write("Qty:");
            Console.WriteLine(Qty);
        }
    }
}






























/**
* @author Anilkumar.S
*
* @date - 8/24/2020 2:24:45 PM 
*/
