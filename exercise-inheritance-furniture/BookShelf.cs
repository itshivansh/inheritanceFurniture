
using System;
using System.Collections.Generic;
using System.Text;


namespace exercise_inheritance_furniture
{
    //child of Furniture
    public class BookShelf:Furniture
    {
        //Add  NoOfShelves  property
        //overrride the Accept method to read NoOfLegs property also
        //
        //override the Display method to include the display of NoOfLegs property also
        public int NoOfShelves;
        public override void Accept()
        {
            base.Accept();
            NoOfShelves = Convert.ToInt32(Console.ReadLine());
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Height::{Height}\nWidth::{Width}\nColor::{Color}\nPrice::{Price}\nQty::{Qty}\nNoOfShelves::{NoOfShelves}");
        }
    }
}

















































/**
* @author Anilkumar.S
*
* @date - 8/24/2020 2:28:32 PM 
*/
