using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Поиск_общих_в_массиве
{
    class Raschet_Class
    {
        int[] A = { 5, 544, 65, 84, -7 }; int[] B = { 5, 678, 544, 97, -9 };
        public int ResChett = 0;
        public void RSC(int ResChet)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == B[i])
                    {
                        ResChett++;
                    }
                }
            }
            return;
        }
    }
}
