using System;
namespace Codility
{
    internal class Program
    {
        static void Main()
        {
            //Console.WriteLine(BinaryGap(32));


            //int[] Test = new int[] { 3, 8, 9, 7, 6 };
            //Console.WriteLine(CyclicRotation(Test, 3));
            //int[] Test2 = new int[] { 2, 3, 1, 5 };
            //Console.WriteLine(PermMissingElem(Test2));
            int[] Test3 = new int[] { 3, 1, 2, 4, 3 };
            Console.WriteLine(TapeEquilibrium(Test3));


        }

        public static int BinaryGap(int N)
        {
            int counter = 0;
            int greatest = 0;
            string bin = Convert.ToString(N, 2);
            foreach (char i in bin)
            {

                if (i == '1')
                {
                    if (counter > greatest)
                    {
                        greatest = counter;
                    }
                    counter = 0;
                }
                else if (i == '0')
                {
                    counter += 1;
                }


            }

            return greatest;
        }
        public static int[] CyclicRotation(int[] A, int k)
        {

            int[] B = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                int counter = A.Length - k;
                counter += i;

                while (counter < 0)
                {
                    counter += A.Length;
                }
                while (counter > A.Length - 1)
                {
                    counter -= A.Length;
                }

                B[i] = (A[counter]);
                Console.WriteLine(A[counter]);
            }
            return B;


        }
        public static int OddOccurrencesInArray(int[] A)
        {
            List<int> previous = new List<int>();
            foreach (int i in A)
            {
                if (previous.Contains<int>(i) == true)
                {
                    previous.Remove(i);
                }
                else
                {
                    previous.Add(i);
                }
            }
            return previous[0];
        }

        public static int FrogJmp(int X, int Y, int D)
        {

            int counter = 0;
            while (X < Y)
            {
                X += D;
                counter++;
            }
            return counter;
        }
        public static int PermMissingElem(int[] A)
        {
            if (A.Length == 1)
            {
                return A[0];
            }
            if (A.Length == 0)
            {
                return 1;
            }
            for (int i = 1; i <= A.Length + 1; i++)
            {
                if (A.Contains(i) == false)
                {
                    return i;
                }


            }
            return 0;
            
        }
        public static int TapeEquilibrium(int[] A)
        {

            int minimumDiff = 100001;

            for (int i = 0; i <= A.Length; i++)
            {
                int[] first = new int[i+1];
                int[] last = new int[A.Length - (i)];
                int firsttotal = 0;
                int lasttotal = 0;
                for (int j = 0; j <= A.Length-1; j++)
                {
                    if (j <= i)
                    {
                        
                        first.Append(A[j]);
                        
                    }
                    else
                    {
                        last.Append(A[j]);
                    }
                }
                foreach (int k in first)
                {
                    firsttotal += k;
                }
                foreach (int l in last)
                {
                    lasttotal += l;
                }
                if (Math.Abs(firsttotal - lasttotal) < minimumDiff)
                {
                    minimumDiff = Math.Abs(firsttotal - lasttotal);

                }
            }
            return minimumDiff;
        }
    }
}