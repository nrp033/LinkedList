namespace Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t----- Welcome To LinkedList -----");

            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(56);
            list.AddLast(30);
            list.AddLast(70);
            foreach(int item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}