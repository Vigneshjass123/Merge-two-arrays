using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_two_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2,3,4 };
            int[] arr2 = { 5,6,7,8,9};
            
                    var myList = new List<int>();
                    myList.AddRange(arr1);
                    myList.AddRange(arr2);
                    int[] c = myList.ToArray();
                    foreach (int K in c)
                    {
                        Console.WriteLine(K);
                    }

                }
            }
        }
    


