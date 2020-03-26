﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Babysitter
{
    public class BabySitter
    {
        static void Main(string[] args)
        {
        }

        // Method   :   CalculateTotalPay
        //
        // Descr.   :   
        //              
        //              
        //              
        //              
        // Input    :   string  Family - family type can be A, B or C
        //              byte    StartHour - exact hour when the babysitter starts
        //              byte    EndHour - exact hour when the babysitter finishes
        //
        // Output   :   string  TotalPay
        public string CalculateTotalPay(string Family, byte StartHour, byte EndHour)
        {
            string TotalPay = "0.00 $";

            if (Family != "A" && Family != "B" && Family != "C")
            {
                TotalPay = "Error: Incorrect family index!";
            }
            else
            {
                if (StartHour < 17)
                {
                    TotalPay = "Error: Invalid start hour (before 5PM)!";
                }
            }

            return TotalPay;
        }
    }
}
