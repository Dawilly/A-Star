using System;
using System.Collections.Generic;
using System.Text;

namespace A_Star {
    public class PriorityQueue<T> {
        //private Node head;
        private int size;

        public PriorityQueue() {
            size = 0;
        }

        //private Node CreateNode(T newData, int priority) {
        //    return new Node(newData, priority);
        //}

        //public T Peek() {
        //    return (T) head.Peek();
        //}

        public void Pop() {

        }

        //public void Push(T newData, int priority) {
        //    Node newNode = CreateNode(newData, priority);
        //    Node start = head;

        //    // Case 1: Head has less priority
        //    if (head.Priority > priority) {
        //        newNode.Next = head;
        //        head.Prev = newNode;
        //        head = newNode;
        //        return;
        //    } 

        //    // Case 2: Middle of list
        //    while(start.Next != null) {
        //        if (start.Next.Priority >= priority) {
                    
        //            return;
        //        }
        //        start = start.Next;
        //    }

        //    // Case 3: End of the list
        //    newNode.Next = start.Next;
        //    start.Next = newNode;
        //    return;
        //}
    }
}
