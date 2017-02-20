using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibMVC.Biz
{
    public class Fibo
    {
        int mFirstNum;
        int mSecondNum;

        public Fibo()
        {
            mFirstNum = 0;
            mSecondNum = 1;

        }

        public List<int> GetNumbers(int indexTo)
        {
            List<int> tmpList = new List<int>();

            int nextNum = -1;

            tmpList.Add(mFirstNum);
            tmpList.Add(mSecondNum);

            for(int x = 2; x < indexTo; x++)
            {
                nextNum = tmpList[x-2] + tmpList[x-1];

                tmpList.Add(nextNum);
            }

            return tmpList;
        }
    }
}
