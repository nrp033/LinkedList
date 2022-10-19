namespace Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t----- Welcome To LinkedList -----");

        Start:
            Console.ReadKey();
            Menu();
            Console.Write("\n\nSelect From Above Option : ");
            int option = Convert.ToInt32(Console.ReadLine());
            LinkedList list=new LinkedList();
            switch (option)
            {
                case 0:
                    break;


                    case 1:
                    LinkedList<int> simple = new LinkedList<int>();
                    simple.AddLast(56);
                    simple.AddLast(30);
                    simple.AddLast(70);
                    foreach (int item in simple)
                    {
                        Console.WriteLine(item);
                    }
                    goto Start;
                    break;

                case 2:
                    list.AddReverse(70);
                    list.AddReverse(30);
                    list.AddReverse(56);
                    list.Display();
                    goto Start;
                    break;

                case 3:
                    list.Append(56);
                    list.Append(30);
                    list.Append(70);
                    list.Display();
                    goto Start;
                    break;

                case 4:
                    list.Append(56);
                    list.Append(70);
                    list.Display();
                    Console.WriteLine("\n\n------- After Insertion ! --------\n");
                    list.Insert(2, 30);
                    list.Display();
                    goto Start;
                    break;

                case 5:
                    list.Append(56);
                    list.Append(30);
                    list.Append(70);
                    list.Display();
                    list.Pop();
                    Console.WriteLine("\n----------After popping out first element----------");
                    list.Display();
                    goto Start;
                    break;
                case 6:
                    list.Append(56);
                    list.Append(30);
                    list.Append(70);
                    list.Display();
                    Console.WriteLine("\n----------After popping out Last element----------");
                    list.PopLast();
                    list.Display();
                    goto Start;
                    break;

                case 7:
                    list.Append(56);
                    list.Append(30);
                    list.Append(70);
                    list.SearchNode(30);
                    goto Start;
                    break;

                case 8:
                    list.Append(56);
                    list.Append(30);
                    list.Append(70);
                    list.Display();
                    int Position = list.SearchNode(30);
                    Position++;
                    list.Insert(Position, 40);
                    Console.WriteLine("\n------ Inserting Node After 30 ------\n");
                    list.Display();
                    goto Start;

                    break;
                case 9:

                    list.Append(56);
                    list.Append(30);
                    list.Append(40);
                    list.Append(70);
                    list.Display();
                    list.size();

                    Console.Write("\nDeleting 40 from the list now \n");
                    list.delElement(40);
                    list.Display();
                    list.size();
                    goto Start;
                    break;




                default:
                    Console.WriteLine("\n***** Wrong Input *****");
                    goto Start;
                    break;




            }




        }
        public static void Menu()
        {
            Console.WriteLine("\n\n1) Simple LinkedList ");
            Console.WriteLine("2) Reverse LinkedList ");
            Console.WriteLine("3) Append int LinkedList");
            Console.WriteLine("4) Insert At Perticular Position");
            Console.WriteLine("5) Deleting First Element From LinkedList");
            Console.WriteLine("6) Deleting Last Element From LinkedList");
            Console.WriteLine("7) Search the Element With Position");
            Console.WriteLine("8) Search Element From List and Insert New Element After Serched Node");
            Console.WriteLine("9) Size of List Befor And After Deletion Element From List");
            Console.WriteLine("\n\nPress 0 to Exit !");
        }
    }
}