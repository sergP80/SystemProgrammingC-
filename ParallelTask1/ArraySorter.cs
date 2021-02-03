using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelTask1
{
    public interface IWorker
    {
        void Start();
        void Stop();
        bool isBusy();
    }

    public class ArraySorter : IWorker
    {
        public bool isBusy()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
