using System;
using System.Collections.Generic;
using System.Text;

namespace A_Star {
    internal class BinaryHeap<T> {
        private class Node {
            public int key;
            public T data;

            public Node(int key, T data) {
                this.key = key;
                this.data = data;
            }
        }

        private Node[] _array;

        public T GetMin => _array[0].data;
        public int Size { get; private set; }
        public int Capacity => _array.Length;

        public BinaryHeap() {
            _array = new Node[1];
            Size = 0;
        }

        private void Swap(int indexOne, int indexTwo) {
            Node temp = _array[indexOne];
            _array[indexOne] = _array[indexTwo];
            _array[indexTwo] = temp;
            return;
        }

        private bool CompareWithParent(int index) {
            return _array[Parent(index)].key > _array[index].key;
        }

        private int Parent(int index) {
            return (index - 1) / 2;
        }

        private int Left(int index) {
            return (index * 2) + 1;
        }

        private int Right(int index) {
            return (index * 2) + 2;
        }

        private void Heapify(int index) {
            int left = Left(index);
            int right = Right(index);
            int smol = index;
            if ((left < Size) && (_array[left].key < _array[index].key)) {
                smol = left;
            } 
            if ((right < Size) && (_array[right].key < _array[smol].key)) {
                smol = right;
            }
            if (smol != index) {
                Swap(index, smol);
                Heapify(smol);
            }
            return;
        }

        public void Insert(int priority, T item) {
            if (Size == _array.Length) {
                Array.Resize(ref _array, _array.Length * 2);
            }
            int key = Size;
            _array[key] = new Node(priority, item);
            Size++;

            while ((key != 0) && (CompareWithParent(key))) {
                Swap(key, Parent(key));
                key = Parent(key);
            }
            return;
        }

        public T Extract() {
            T results;
            if (Size == 0) return default;
            if (Size == 1) {
                results = _array[0].data;
                Size--;
                _array[0] = null;
                return results;
            }

            results = _array[0].data;
            _array[0] = _array[Size - 1];
            Size--;
            Heapify(0);

            return results;
        }

        public void Delete(int index) {
            Decrease(index, -1);
            Extract();
        }

        public void Decrease(int index, int newKey) {
            _array[index].key = newKey;

        }
    }
}
