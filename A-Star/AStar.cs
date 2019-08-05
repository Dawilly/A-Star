using System;

namespace A_Star
{
    public class AStar<T> {
        public AStar() {

        }

        public void Search(T start, T end) {
            PriorityQueue<T> pQueue = new PriorityQueue<T>();
            pQueue.Enqueue(0, start);

            // camefrom and cost so far

            while (pQueue.Size > 0) {
                T current = pQueue.Dequeue();
                //if current.Equals(end)
                    //reconstruct path
                
                //T next in neighbors
                foreach(T next in ) {

                }
            }
        }


    }
}
