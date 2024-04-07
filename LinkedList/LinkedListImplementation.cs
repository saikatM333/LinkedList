

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
    public void append(T data)
    {
        count++;
        node<T> node = new node<T>(data);
        if (Head == null)
        {
            Head = node;
        }
        else
        {
            node.Next = Head;
            Head = node;
        }
    }
    public void insert(T data)
    {
        count++;
        node<T> node = new node<T>(data);

        if (Head == null)
        {
            Head = node;
        }
        else
        {
            node<T> temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = node;
        }
    }
}

public class LinkedListImplementation
{
    public  static void Main(string[] args)
    {
        Console.WriteLine("Linked list implemntation ");
    }
}