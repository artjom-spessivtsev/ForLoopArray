namespace ForLoopArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vaja teha string array H, e, l, l, o
            //kasutada for loopi


            string[] array = { "H", "e", "l", "l", "o" };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            //tuleb kasutada foreachi
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

        }
    }
}
