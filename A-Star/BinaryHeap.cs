using System;
using System.Collections.Generic;
using System.Text;

namespace A_Star {
    public class BinaryHeap<T> {
        private T[] _array;
        private Reader reader;
        private Writer writer;

        public delegate void Writer(T data, int val);
        public delegate int Reader(T data);

        public T GetMin => _array[0];
        public int Size { get; private set; }
        public int Capacity => _array.Length;



        public BinaryHeap(Reader reader, Writer writer) {
            this.reader = reader;
            this.writer = writer;
            _array = new T[1];
            Size = 0;
        }

        private void Swap(int indexOne, int indexTwo) {
            T temp = _array[indexOne];
            _array[indexOne] = _array[indexTwo];
            _array[indexTwo] = temp;
            return;
        }

        private bool CompareWithParent(int index) {
            return reader(_array[Parent(index)]) > reader(_array[index]);
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
            if ((left < Size) && (reader(_array[left]) < reader(_array[index]))) {
                smol = left;
            } 
            if ((right < Size) && (reader(_array[right]) < reader(_array[smol]))) {
                smol = right;
            }
            if (smol != index) {
                Swap(index, smol);
                Heapify(smol);
            }
            return;
        }

        public void Insert(T item) {
            if (Size == _array.Length) {
                Array.Resize(ref _array, _array.Length * 2);
            }
            int key = Size;
            _array[key] = item;
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
                results = _array[0];
                Size--;
                _array[0] = default;
                return results;
            }

            results = _array[0];
            _array[0] = _array[Size - 1];
            Size--;
            Heapify(0);

            return results;
        }

        public void Delete(int index) {
            Decrease(index, -1);
            Extract();
            return;
        }

        public void Decrease(int index, int newKey) {
            writer(_array[index], newKey);
            while((index != 0) && (CompareWithParent(index))) {
                Swap(index, Parent(index));
                index = Parent(index);
            }
            return;
        }
    }
}
