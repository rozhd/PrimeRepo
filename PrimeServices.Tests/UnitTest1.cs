using NUnit.Framework;
using PrimeServices;

namespace Tests
{
    public class Tests
    {
        [TestFixture]
        public class PrimeService_IsPrimeShould
        {
            [TestCase(1)]
            [TestCase(2)]
            [TestCase(3)]
            [TestCase(5)]
            [TestCase(7)]
            public void IsPrimeTest(int value)
            {
                PrimeService primeService = CreatePrimeService();
                var result = primeService.IsPrime(value);

                Assert.IsTrue(result, $"{value} is not prime");
            }

            
            [TestCase(4)]
            [TestCase(6)]
            [TestCase(8)]
            public void IsNotPrimeTest(int value)
            {
                PrimeService primeService = CreatePrimeService();
                var result = primeService.IsPrime(value);

                Assert.IsFalse(result, $"{value} is prime");
            }



            /*
            More tests
            */

            private PrimeService CreatePrimeService()
            {
                return new PrimeService();
            }
        }
    }
}