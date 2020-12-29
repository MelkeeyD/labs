using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace labs
{
    class AllFunc
    {
        public static ArrayList NewCol(int i)
        {
            Random ran = new Random();
            ArrayList arr = new ArrayList();
            for (int j = 0; j < i; j++)
                arr.Add(ran.Next(100, 2000));
            return arr;
        }

        public static void Tes(ArrayList arr, ListBox Anw)
        {
            foreach (int a in arr)
                Anw.Items.Add(a);
        }

        public static int broi(ArrayList myAL) //4. Сколько элементов массива составляют со своими соседями упорядоченную последовательность. Первый и последний элементы массива считаются соседними.
        {
            int count = 0;
            for (int i = 0; i < myAL.Count; i++)
            {
                if (i == 0 && (((int)myAL[i] > (int)myAL[myAL.Count - 1] && (int)myAL[i] < (int)myAL[i + 1]) || ((int)myAL[i] < (int)myAL[myAL.Count - 1] && (int)myAL[i] > (int)myAL[i + 1])))
                {
                    count++;
                }
                if (i == myAL.Count - 1 && (((int)myAL[i] > (int)myAL[i - 1] && (int)myAL[i] < (int)myAL[0]) || ((int)myAL[i] < (int)myAL[i - 1] && (int)myAL[i] > (int)myAL[0])))
                {
                    count++;
                }
                if ((i != 0 && i != myAL.Count - 1) && (((int)myAL[i] > (int)myAL[i - 1] && (int)myAL[i] < (int)myAL[i + 1]) || ((int)myAL[i] < (int)myAL[i - 1] && (int)myAL[i] > (int)myAL[i + 1])))
                {
                    count++;
                }
            }
            return count;
        }

        public static void bro(ArrayList myAL)
        {

            int kek;
            for (int i = 1; i < myAL.Count - 1; i = i + 3)
            {
                if ((int)myAL[i] > (int)myAL[i - 1] && (int)myAL[i] > (int)myAL[i + 1])
                {
                    if ((int)myAL[i - 1] < (int)myAL[i + 1])
                    {
                        kek = (int)myAL[i];
                        myAL[i] = myAL[i + 1];
                        myAL[i + 1] = kek;
                    }
                    else
                    {
                        kek = (int)myAL[i];
                        myAL[i] = myAL[i - 1];
                        myAL[i - 1] = kek;
                    }
                }
                else if ((int)myAL[i] < (int)myAL[i - 1] && (int)myAL[i] < (int)myAL[i + 1])
                {
                    if ((int)myAL[i - 1] < (int)myAL[i + 1])
                    {
                        kek = (int)myAL[i];
                        myAL[i] = myAL[i - 1];
                        myAL[i - 1] = kek;
                    }
                    else
                    {
                        kek = (int)myAL[i];
                        myAL[i] = myAL[i + 1];
                        myAL[i + 1] = kek;
                    }
                }
            }
        }
    }
}
