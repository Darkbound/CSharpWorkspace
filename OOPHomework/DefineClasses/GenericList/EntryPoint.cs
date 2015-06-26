namespace GenericList
{
    using System;

    public class EntryPoint
    {
        static void Main()
        {
            MyList<int> myList = new MyList<int>();

            for (int i = 0; i < 10; i++)
            {
                myList.Add(i);
            }

            Console.WriteLine(myList.ToString());

            Console.WriteLine();

            Console.WriteLine("Count: {0}", myList.Count);
            Console.WriteLine("Capacity: {0}", myList.Capacity);

            Console.WriteLine();

            myList.RemoveAt(3);
            Console.WriteLine(myList.ToString());

            Console.WriteLine();

            myList.Insert(2, 5); 
            Console.WriteLine(myList.ToString());

            Console.WriteLine();

            Console.WriteLine(myList.IndexOf(3));
            Console.WriteLine(myList.IndexOf(5));

            Console.WriteLine();

            Console.WriteLine(myList.Contains(7));

            Console.WriteLine();

            myList.Clear();
            Console.WriteLine(myList.ToString());
        }
    }
}
