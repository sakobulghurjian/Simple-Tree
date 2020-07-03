using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exapmle
{
    class Program
    {
        static void Main(string[] args)
        {
			Node head = null;
			Random rnd = new Random();
			int T = 5;
			while (T-- > 0)
			{
				int data = rnd.Next(0, 5);
				head = insert(head, data);
			}
			display(head);

			Console.ReadKey();
		}
		public static Node insert(Node head, int data)
		{
			// if list has no elements, return a new node
			if (head == null)
			{
				return new Node(data);
			}

			// else iterate through list, add node to tail, and return head
			Node tmp = head;
			while (tmp.next != null)
			{
				tmp = tmp.next;
			}
			tmp.next = new Node(data);

			return head;
		}
		public static void display(Node head)
		{
			Node start = head;
			while (start != null)
			{
				Console.Write(start.data + " ");
				start = start.next;
			}
		}
	}

	class Node
	{
		public int data;
		public Node next;
		public Node(int d)
		{
			data = d;
			next = null;
		}

	}
}
