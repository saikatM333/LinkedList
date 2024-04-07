

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
    public T deleteLast()
    {
        count--;
        if (Head == null)
        {
            Console.WriteLine("no elemnt present to delete ");
            count++;

        }

        node<T> temp = Head;
        while (temp.Next.Next != null)
        {
            temp = temp.Next;
        }
        T data = temp.Next.Data;
        temp.Next = null;
        return data;
    }
    public void insertInBetween(int position, T value)
    {
        node<T> newNode = new node<T>(value);
        int current = 0;
        if (position <= -1)
        {
            Console.WriteLine("enter the position more than 0");
        }
        else if (position > count)
        {
            node<T> temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;

            }
            temp.Next = newNode;
        }
        else if (count == 0)
        {
            Head = newNode;
        }
        else
        {
            node<T> temp = Head;
            while (temp != null && current < position - 1)
            {
                current++;
                temp = temp.Next;
            }
            newNode.Next = temp.Next;
            temp.Next = newNode;
        }
    }

    public T deleteFirst()
    {
        count--;
        if (Head == null)
        {
            Console.WriteLine("no element to delete in linked list ");
            count++;
        }
        T data = Head.Data;
        Head = Head.Next;
        return data;
    }
    public void display()
    {
        Console.WriteLine(" display the element of the linked list ");
        node<T> temp = Head;
        while (temp != null)
        {
            if (temp.Next != null)
            {
                Console.Write(temp.Data + "->");
                temp = temp.Next;
            }
            else
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }
    }
}

public class LinkedListImplementation
{
    public  static void Main(string[] args)
    {
        Console.WriteLine("Linked list implemntation "); 
        CustomLinkedList<int> customLinkedList = new CustomLinkedList<int>();
        customLinkedList.append(1);
        customLinkedList.append(2);
        customLinkedList.insert(3);
        customLinkedList.insert(4);
        customLinkedList.insertInBetween(1, 5);
        customLinkedList.display();



    }
}