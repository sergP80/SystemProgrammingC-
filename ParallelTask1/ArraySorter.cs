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
        void StartAsync();
        void Stop();
        bool IsBusy { get; set; }
    }

    public interface ISorter
    {
        void Sort();
    }

    public class ArraySorter<T> : IWorker, ISorter where  T: IComparable<T>
    {
        private T[] array;

        Task task;

        public ArraySorter(T[] array)
        {
            this.array = array;
        }

        public int From { get; set; }

        public int To { get; set; }

        public bool IsBusy { get; set; }

        public void Start()
        {
            Sort();
        }

        public void StartAsync()
        {
            this.task = Task.Factory.StartNew(Sort);
        }

        public void Stop()
        {
            if (task.Status != TaskStatus.Running)
            {
                return;
            }            
        }

        public void Sort()
        {
            for (var i = From; i <= To; ++i)
            {
                var k = i;
                for (var j = i + 1; j <= To; ++j)
                {
                    if (array[i].CompareTo(array[j]) > 0)
                    {
                        k = j;
                    }
                }

                if (k > i)
                {
                    var temp = array[k];
                    array[k] = array[i];
                    array[i] = temp;
                }
            }
        }
    }
}
