using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfThree
{
    class SumAlgorithm
    {
        public SumAlgorithm(){
            }

        public int firstOp { get; set; }
        public int secondOp { get; set; }
        public int thirdOp { get; set; }

        public void calculateSum(int firstOp, int secondOp, int thirdOp)
        {
            var newForm = new SumForm();
            newForm.viewResult(firstOp * secondOp, firstOp * thirdOp, 
                reverseINum((firstOp + thirdOp) * secondOp));

        }

        private int reverseINum(int num)
        {
            String str = num.ToString();
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            str = new String (arr);
            num = Int32.Parse(str);
            return num;
        }
    }
}
