using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogratims_home_work
{
    class BinarySearchExample
    {
        public static int IterativeBinary(int[] array, int target)
        {

            int left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                //تحقق اذا كانت القيمة في المنصف هي الهدف 
                if (array[mid] == target)
                {
                    return mid;

                }
                //اذا كانت القيمة الهدف اكبر تجاهل الجزء الايسر
                else if (array[mid] < target)
                {
                    left = mid + 1;
                }
                //اذا كانت القيمة الهدف اصغر تجاهل الجزء الايمن 
                else
                {
                    right = mid - 1;
                    {
                        {
                            return -1;
                        }

                    }
                }
            }
        }
    }
        class RecursiveBinarySearch
        { 
            public static int RecursiveBinarySearch(int[] array, int target, int left, int right)
            {
                if (left > right)
                {
                    return -1;
                }
                int mid = left + (right - left) / 2;
                if (array[mid] == target)
                {
                    return mid;

                }
                else if (array[mid] < target)
                {
                    return RecursiveBinarySearch(array, target, mid + 1, right);
                }
                else
                {
                    return RecursiveBinarySearch(array, target, left, mid - 1);
                }

            }
        }
        








            
          

            

           
       
            
            
            
            



    