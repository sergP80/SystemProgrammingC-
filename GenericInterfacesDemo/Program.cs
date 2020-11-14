using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GenericInterfacesDemo
{
    interface IMovable
    {
        void Move();

        void Stop();
    }

    interface IRounable
    {
        void Round();
    }

    interface IRoundMoveable: IMovable, IRounable { }

    class Car: IRoundMoveable
    {
        double Weigth { get; set; }

        public void Move()
        {
            Console.WriteLine("Car moving...");
        }

        public void Round()
        {
            Console.WriteLine("Core rounded");
        }

        public void Stop()
        {
            Console.WriteLine("Car stay here");
        }
    }


    interface IDirectable
    {
        void Direct(double angle);
    }

    class Person : IMovable, IDirectable
    {
        public void Direct(double angle)
        {
            Console.WriteLine("Direct changed to {0}", angle);
        }

        public void Move()
        {
            Console.WriteLine("Person moving...");
        }

        public void Stop()
        {
            Console.WriteLine("Person stay here");
        }
    }

    class Program
    {
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        public static void SelectSort<T>(T[] a) where T : IComparable<T>
        {
            for (int i = 0; i < a.Length - 1; ++i)
            {
                var minIndex = i;
                for (int j = i + 1; j < a.Length; ++j)
                {
                    if (a[j].CompareTo(a[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex > i)
                {
                    Swap(ref a[i], ref a[minIndex]);
                }
            }
        }

        public static void PrintArray<T>(T[] a)
        {
            Console.Write("[");
            for (int i = 0; i < a.Length; ++i)
            {
              if (i > 0)
                {
                    Console.Write(", ");
                }

                Console.Write("{0}", a[i]);
            }
            Console.WriteLine("]");
        }

        class Tuple2<T1, T2>
        {
            public T1 T_1 { get; set; }
            public T2 T_2 { get; set; }
        }

        class Pair<K, V>: IComparable<Pair<K, V>> where K: IComparable<K>
                                                  where V: IComparable<V>
        {
            public K Key { get; set; }
            public V Value { get; set; }

            public int CompareTo(Pair<K, V> other)
            {
                if (Key.CompareTo(other.Key) < 0 && Value.CompareTo(other.Value) < 0)
                {
                    return -1;
                }

                if (Key.CompareTo(other.Key) > 0 && Value.CompareTo(other.Value) > 0)
                {
                    return 1;
                }

                if (Key.CompareTo(other.Key) == 0 && Value.CompareTo(other.Value) == 0)
                {
                    return 0;
                }

                throw new InvalidOperationException("Not compare objects");
            }

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public override string ToString()
            {
                return string.Format("[Key={0}, Value={1}]", Key, Value);
            }
        }
        class Tuple3<T1, T2, T3>
        {
            public T1 T_1 { get; set; }
            public T2 T_2 { get; set; }
            public T3 T_3 { get; set; }
        }

        static void Main(string[] args)
        {
            IMovable[] moveObjects = { new Car(), new Person() };
            foreach (var mo in moveObjects)
            {
                mo.Move();
                Thread.Sleep(2000);
                mo.Stop();
            }

            int[] a1 = { 1, -1, 10, 2 - 4, 7 };
            PrintArray(a1);
            SelectSort(a1);
            PrintArray(a1);

            double[] a2 = { -2.1, 22.4, 7.15, -4.05 };
            PrintArray(a2);
            SelectSort(a2);
            PrintArray(a2);

            var pair1 = new Pair<int, string>();
            pair1.Key = 1;
            pair1.Value = "Adfsgdf";

            Console.WriteLine("{0}", pair1);
        }
    }
}
