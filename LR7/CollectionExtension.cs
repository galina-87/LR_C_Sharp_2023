using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LR7
{
    public static class CollectionExtension
    {
        public static IEnumerable<T> TakeOdd<T>(this IEnumerable<T> collection)
        {
            int index = 0;
            foreach (T element in collection)
            {
                if (index % 2 != 0)
                {
                    yield return element;
                }

                index++;
            }
        }

        public static IEnumerable<T> TakeEven<T>(this IEnumerable<T> collection)
        {
            int index = 0;
            foreach (T element in collection)
            {
                if (index % 2 == 0)
                {
                    yield return element;
                }

                index++;
            }
        }

        public static IEnumerable<T> TakeNegative<T>(this IEnumerable<T> collection)
        {
            foreach (T element in collection)
            {
                Type objType = element.GetType();
                objType = Nullable.GetUnderlyingType(objType) ?? objType;

                if (objType.IsPrimitive
                    && objType != typeof(bool) 
                    && objType != typeof(char)
                    && objType != typeof(IntPtr) 
                    && objType != typeof(UIntPtr)
                    || objType == typeof(decimal))
                {
                    if (Decimal.Parse(element.ToString()) < 0)
                    {
                        yield return element;
                    }
                }
            }
        }

        public static IEnumerable<T> TakePositive<T>(this IEnumerable<T> collection)
        {
            foreach (T element in collection)
            {
                Type objType = element.GetType();
                objType = Nullable.GetUnderlyingType(objType) ?? objType;

                if (objType.IsPrimitive
                    && objType != typeof(bool)
                    && objType != typeof(char)
                    && objType != typeof(IntPtr)
                    && objType != typeof(UIntPtr)
                    || objType == typeof(decimal))
                {
                    if (Decimal.Parse(element.ToString()) >= 0)
                    {
                        yield return element;
                    }
                }
            }
        }

        public static IEnumerable<double> SmoothByMovingAverage(this IEnumerable<double> collection, int width)
        {
            var queue = new Queue<double>(width);
            foreach (double element in collection)
            {
                if (queue.Count == width)
                {
                    queue.Dequeue();
                }
                queue.Enqueue(element);
                
                yield return queue.Average();
              
            }
        }

        public static IEnumerable<int> SmoothByMovingAverage(this IEnumerable<int> collection, int width)
        {
            var queue = new Queue<int>(width);
            foreach (int element in collection)
            {
                if (queue.Count == width)
                {
                    queue.Dequeue();
                }
                queue.Enqueue(element);

                yield return (int)queue.Average();

            }
        }

        public static IEnumerable<decimal> SmoothByMovingAverage(this IEnumerable<decimal> collection, int width)
        {
            var queue = new Queue<decimal>(width);
            foreach (int element in collection)
            {
                if (queue.Count == width)
                {
                    queue.Dequeue();
                }
                queue.Enqueue(element);

                yield return (decimal)queue.Average();

            }


        }

        public static void PrintEnum<T>(this IEnumerable<T> collection)
        {
            Console.WriteLine("Elements: ");
            foreach (T element in collection)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine("***");
        }
    }
}
