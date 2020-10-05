
using System;
using System.Collections.Generic;
using System.Text;


namespace exercise_inheritance_furniture
{
    //child of furniture
    public class DiningTable : Furniture
    {
        //Add  NoOfLegs  property
        //overrride the Accept method to read NoOfLegs property also
        //
        //override the Display method to include the display of NoOfLegs property also
       public int NoOfLegs { get; set; }
        public override void Accept()
        {
            base.Accept();
            NoOfLegs = Convert.ToInt32(Console.ReadLine());
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Height::{Height}\nWidth::{Width}\nColor::{Color}\nPrice::{Price}\nQty::{Qty}\nNoOfLegs::{NoOfLegs}");
        }
    }
}


















































/**
* @author Anilkumar.S
*
* @date - 8/24/2020 2:27:28 PM 
*/
