using LinkedList;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Arrange
            var linkedlist = new SingleLinkedList<int>();

            // Act
            linkedlist.AddLast(1);
            linkedlist.AddLast(2);
            linkedlist.AddLast(3);
            linkedlist.AddLast(4);
            linkedlist.AddLast(5);
            linkedlist.AddLast(6);

            var getCheck = linkedlist.Get(3);
            var nodeValue = getCheck?.Value;
        }
    }
}