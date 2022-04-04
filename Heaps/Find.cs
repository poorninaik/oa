using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oa.Heaps
{
    public class MedianFinder
    {
        readonly PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();
        readonly PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
        public MedianFinder()
        {
            _maxHeap = new List<double>();
        }

        public void AddNum(int num)
        {
            var index = _maxHeap.BinarySearch(num);
            if (index < 0)
                index = -(index + 1);
            _maxHeap.Insert(index, num);
        }

        public double FindMedian()
        {
            var count = _maxHeap.Count;
            if (count % 2 != 0)
                return _maxHeap[count / 2];
            else
                return (_maxHeap[count / 2] + _maxHeap[count / 2 - 1]) / 2;
        }
    }

    /**
     * Your MedianFinder object will be instantiated and called as such:
     * MedianFinder obj = new MedianFinder();
     * obj.AddNum(num);
     * double param_2 = obj.FindMedian();
     */
    class Find
    {
        private List<double> _maxHeap;
        public Find()
        {
            _maxHeap = new List<double>();
        }

        public void AddNum(int num)
        {
            var index = _maxHeap.BinarySearch(num);
            if (index < 0)
                index = -(index + 1);
            _maxHeap.Insert(index, num);
        }

        public double FindMedian()
        {
            var count = _maxHeap.Count;
            if (count % 2 != 0)
                return _maxHeap[count / 2];
            else
                return (_maxHeap[count / 2] + _maxHeap[count / 2 - 1]) / 2;
        }
    }
}
