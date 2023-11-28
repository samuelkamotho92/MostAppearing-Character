﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesAndOperators
{
    public class MostAppearing
    {
        public object countString()
        {
            //create a Dictionary having Tkey and TValue having key and value pair
            Dictionary<char, int> result = new Dictionary<char, int>();
            //Enter input values
            Console.WriteLine("Enter Input Value to check repeating string");
            string enteredString = Console.ReadLine().ToLower();
            for (int i = 0; i < enteredString.Length; i++)
            {
                char sValue = enteredString[i];
                //check if the value does exist if yes increase initial by 1
                if (result.ContainsKey(sValue))
                {
                    result[sValue]++;
                }
                else
                {
                    //If not initial Value will be 1
                    result[sValue] = 1;
                }

                /* Console.WriteLine(i + ": " + enteredString[i]); */
            }
            foreach (var entry in result)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
            return result;
        }
    }
}
