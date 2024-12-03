namespace _03._12.Entites;

public class Array : IOutput
{
    public int[] Numbers;
    public int Size;
    
    public Array()
    {
        Size = 0;
        Numbers = new int[0];
    }
    public Array(int numbers)
    {
        Size = 0;
        Numbers = new int[numbers];
    }
    public void Add(int number)
    {
        if(Size < Numbers.Length)
        {
            Numbers[Size] = number;
            Size++;
        }
        else
        {
            int[] temp = new int[Numbers.Length + 1];
            for (int i = 0; i < Numbers.Length; i++)
            {
                temp[i] = Numbers[i];
            }
            temp[Numbers.Length] = number;
            Numbers = temp;
            Size++;
        }
    }
    
    public void Show()
    {
        foreach (var number in Numbers)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
    }
    
    public void Show(string message)
    {
        Console.WriteLine(message);
        Show();
    }

}