
using LR6;

SinglyLinkedList<int> ints = new SinglyLinkedList<int>();

for (int j  = 0; j < 10; j++)
{
    ints.Add(j);
}
foreach (int i in ints)
{
    Console.WriteLine(i);
}

ints.Remove(8);
foreach (int i in ints)
{
    Console.WriteLine(i);
}