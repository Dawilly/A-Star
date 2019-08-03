using System;
using System.Collections.Generic;
using System.Text;

namespace A_Star {
    public class PriorityQueue<T> {
        private class Node {
            public int priority;
            public T data;

            public Node(int priority, T data) {
                this.priority = priority;
                this.data = data;
            }
        }
        private BinaryHeap<Node> heap;

        public int Size => heap.Size;
        public int Capacity => heap.Capacity;

        public PriorityQueue() {
            heap = new BinaryHeap<Node>(ReadPriority, WritePriority);
        }

        private static int ReadPriority(Node node) {
            return node.priority;
        }

        private static void WritePriority(Node node, int value) {
            node.priority = value;
        }

        public T Peek() {
            return heap.GetMin.data;
        }

        public T Dequeue() {
            Node removedNode = heap.Extract();
            return removedNode.data;
        }

        public void Enqueue(int priority, T data) {
            Node freshNode = new Node(priority, data);
            heap.Insert(freshNode);
            return;
        }
    }
}
