using A_Star;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit.Sdk;

namespace A_StarTest {
    [TestClass]
    public class BinaryHeapTest {
        [TestMethod]
        public void TestMethod1() {
            BinaryHeap<SimpleInt> heap = new BinaryHeap<SimpleInt>(ReadInt, WriteInt);
            int one;
            int two;
            int three;

            heap.Insert(new SimpleInt(3));
            heap.Insert(new SimpleInt(2));
            heap.Delete(1);
            heap.Insert(new SimpleInt(15));
            heap.Insert(new SimpleInt(5));
            heap.Insert(new SimpleInt(4));
            heap.Insert(new SimpleInt(45));
            one = heap.Extract().value;
            two = heap.GetMin.value;
            heap.Decrease(2, 1);
            three = heap.Extract().value;
            Assert.AreEqual(2, one);
            Assert.AreEqual(4, two);
            Assert.AreEqual(1, three);
        }

        public class SimpleInt {
            public int value;

            public SimpleInt(int value) {
                this.value = value;
            }
        }

        private int ReadInt(SimpleInt x) {
            return x.value;
        }

        private void WriteInt(SimpleInt x, int val) {
            x.value = val;
        }
    }
}
