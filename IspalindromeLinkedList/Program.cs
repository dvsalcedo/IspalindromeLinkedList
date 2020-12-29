using System;
using System.Collections;

namespace IspalindromeLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is it Palindrome?");
            LinkedLists linklist1 = new LinkedLists();

            linklist1.append(7);
            linklist1.append(1);
            linklist1.append(7);
              
            Console.WriteLine(IspalindromeLinkedList(linklist1.First()));    
        }

        static bool IspalindromeLinkedList(Node head){
            Node sp = head, fp = head, mid, node= head;
            Stack stack = new Stack();

            while (fp != null && fp.next != null) {
                sp = sp.next;
                fp = fp.next.next;
            }

            // odd => fp is not null
            if (fp != null) {
                mid = sp;
            } else {
                mid = sp.next;
            }

            while (mid != null){
                stack.Push(mid.value);
                mid = mid.next;
            }

            while (node != null && stack.Count > 0) {
                if ( node.value != (int)stack.Pop() ) {
                    return false;
                }
                node = node.next;
            }
            
            return true;
        }
    }
}
