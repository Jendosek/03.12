﻿using System.Text;
using _03._12.Entities;

namespace _03._12;

class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;  
        Console.OutputEncoding = Encoding.Unicode;
        
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Arr arr = new Arr(array);
        
        Console.WriteLine($"Less than 5: {arr.Less(6)}");
        Console.WriteLine($"Greater than 5: {arr.Greater(4)}");
    }
}