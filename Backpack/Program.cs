using System;

class Program
{
    static void BackPackAlgorithm(int BPparameter, int itemsWeight, int itemsValue)
    {
        
        

        
    }

    public static void Main()
    {
        Console.WriteLine("Type BackPack parameter:");
        int BPparameter = 0;
        Console.WriteLine("Type items weight:");
        int[] itemsWeight = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine("Type items value:");
        int[] itemsValue = Console.ReadLine().Split().Select(int.Parse).ToArray();
    }
}