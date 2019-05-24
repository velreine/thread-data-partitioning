using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Partitioned_Compute_With_Multiple_Threads
{
    internal class ArrayProcessor
    {
        private readonly double[] _data;
        private readonly int _firstIndex;
        private readonly int _lastIndex;

        public ArrayProcessor(double[] data, int firstIndex, int lastIndex)
        {
            _data = data;
            _firstIndex = firstIndex;
            _lastIndex = lastIndex;
        }

        public void ComputeSum()
        {
            Sum = 0;

            for (int n = _firstIndex; n <= _lastIndex; n++)
            {
                Sum += _data[n];
                Thread.Sleep(1);
            }
        }

        public double Sum { get; private set; }
    }
}
