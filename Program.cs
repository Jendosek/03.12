using System.Text;
using _03._12.Entites; 

namespace _03._12;

class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        
        Array array = new Array();
        array.Add(1);
        array.Add(2);
        array.Add(3);
        array.Show();
        array.Show("Array:");
    }
}