class Program
{
    static void Main(string[] args)
    {
        string[] originalArray = { "hello", "2", "world", ":-)" };

        int count = 0;
        for (int i = 0; i < originalArray.Length; i++)
        {
            if (originalArray[i].Length <= 3)
            {
                count++;
            }
        }

        string[] newArray = new string[count];
        int index = 0;
        for (int i = 0; i < originalArray.Length; i++)
        {
            if (originalArray[i].Length <= 3)
            {
                newArray[index] = originalArray[i];
                index++;
            }
        }

        Console.WriteLine("Исходный массив: " + string.Join(", ", originalArray));
        Console.WriteLine("Новый массив: " + string.Join(", ", newArray));
    }
}
