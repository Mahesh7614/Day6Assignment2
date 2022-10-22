﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment2
{
    public class DecimalToBinaryConversion
    {
        public int DNumber;

        public DecimalToBinaryConversion(int dnumber)
        {
            DNumber = dnumber;
        }
        public static DecimalToBinaryConversion UserInputForDecimalToBinary()
        {
            Console.WriteLine("Enter the Decimal Number : ");
            int dc = Convert.ToInt32(Console.ReadLine());

            return new DecimalToBinaryConversion(dc)
            {
                DNumber=dc
            };
        }
        public void ConvertDecimalToBinary()
        {
            string result = " ";

            while( DNumber > 0)
            {
                //numberArray[i] = DNumber % 2;
                int r = DNumber % 2;
                result = Convert.ToString(r) + result;
                DNumber /= 2;

            }
            Console.WriteLine("Binary Representation of the Given Number is : " + result); 
        }
    }
}
// Decimal To Binary Conversion Problem