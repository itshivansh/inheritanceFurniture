
using System;
using System.Collections.Generic;
using System.Text;
namespace exercise_inheritance_furniture
{
   public class Furniture
    {
        //Add below mentioned Properties 
        //Height(int),Width(int),Color(string),Price(double),Qty(int)
       public int Height { get; set; }
        public int Width { get; set; }
       public string Color { get; set; }
       public double Price { get; set; }
        public int Qty { get; set; }
        public virtual void Accept()
        {
            //code to accept height,width ,color,price and qty
            Height = Convert.ToInt32(Console.ReadLine());
            Width = Convert.ToInt32(Console.ReadLine());
            Color = Console.ReadLine();
            Price = Convert.ToDouble(Console.ReadLine());
            Qty = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void Display()
        {
            //code to display height width ,price,qty and color
            Console.WriteLine($"Height::{Height}\nWidth::{Width}\nColor::{Color}\nPrice::{Price}\nQty::{Qty}");
            
        }
    }
}






























/**
* @author Anilkumar.S
*
* @date - 8/24/2020 2:24:45 PM 
*/
