using A_Star;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;

namespace A_StarTest {
    [TestClass]
    public class BinaryHeapTest {
        [TestMethod]
        public void TestMethod1() {
            BinaryHeap<int> heap = new BinaryHeap<int>();
            int one;
            int two;
            int three;

            heap.Insert(3, 3);
            heap.Insert(2, 2);
            heap.Delete(1);
            heap.Insert(15, 15);
            heap.Insert(5, 5);
            heap.Insert(4, 4);
            heap.Insert(45, 45);
            one = heap.Extract();
            two = heap.GetMin;
            heap.Decrease(2, 1);
            three = heap.Extract();
            Assert.AreEqual(2, one);
            Assert.AreEqual(4, two);
            Assert.AreEqual(5, three);
        }
    }
}
