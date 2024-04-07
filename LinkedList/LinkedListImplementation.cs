

using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

public class node<T>
{  
    public T Data { get; set; }
    public node<T> Next { get; set; }
public node(T data)
    {
        Data = data;
        Next = null;
    }
}
public class CustomLinkedList<T>
{
    private node<T> Head;
    private int count;
    public CustomLinkedList()
    {
        Head = null;
        count = 0;
    }
}

    public class LinkedListImplementation
{
    public  static void Main(string[] args)
    {
        Console.WriteLine("Linked list implemntation ");
    }
}