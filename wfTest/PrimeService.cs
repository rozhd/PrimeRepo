using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeServices
{
    public class PrimeService
    {
        public bool IsPrime(int N)
        {
            
                for (int i = 2; i < N; i++)
                {
                    if (N % i == 0)
                        return false;
                        
                }
                return true;
            
        }
    }
}
