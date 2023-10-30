using System;
using System.Collections.Generic;

//assignment one
public class Node<T>
{
    public int Data { get; set; }
    public Node<T> Next { get; set; }

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList
{
    public Node<int> Head { get; set; }

    public LinkedList()
    {
        Head = null;
    }

    public void Add(int data)
    {
        Node<int> newNode = new Node<int>(data);
        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            Node<int> current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    //assignment one
    public void RecursivePrint(Node<int> current)
    {
        if (current == null)
        {
            Console.WriteLine("finished");
            return;
        }

        Console.Write(current.Data + " - ");
        RecursivePrint(current.Next);
    }
}

//assignment two
public class BinaryLinkedListNode
{
    public int Value { get; set; }
    public BinaryLinkedListNode Left { get; set; }
    public BinaryLinkedListNode Right { get; set; }


    public static bool BinarySearch(BinaryLinkedListNode head, int target)
    {
        BinaryLinkedListNode current = head;

        while (current != null)
        {
            if (current.Value == target)
            {
                return true;
            }
            else if (target < current.Value)
            {
                current = current.Left;
            }
            else
            {
                current = current.Right;
            }
        }

        return false;
    }
}

//assignment 3
public class CircularLinkedList<T>
{
    private Node<T> head;

    public int Size()
    {
        if (head == null)
        {
            return 0;
        }
        return SizeRecursive(head, 1);
    }

    private int SizeRecursive(Node<T> currentNode, int size)
    {
        if (currentNode.Next == head)
        {
            return size;
        }
        return SizeRecursive(currentNode.Next, size + 1);
    }
}


//assignment 4
public class ShellSort
{
    public static void Sort(int[] arr, int val)
    {
        int gap = arr.Length / 2;

        SortRecursive(arr, gap);

        if (gap != 1)
        {
            Sort(arr, gap / 2);
        }
    }

    private static void SortRecursive(int[] arr, int gap)
    {
        if (gap == 1)
        {
            return;
        }

        for (int i = gap; i < arr.Length; i++)
        {
            int current = arr[i];
            int j = i - gap;

            while (j >= 0 && arr[j] > current)
            {
                arr[j + gap] = arr[j];
                j -= gap;
            }

            arr[j + gap] = current;
        }

        SortRecursive(arr, gap / 2);
    }
}




