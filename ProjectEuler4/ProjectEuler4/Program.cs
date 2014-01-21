using System;
using System.Text;

namespace ProjectEuler4
{
    class Program
    {
        static void Main()
        {
            const int lowerNumber = 100;
            const int upperNumber = 999;
            var largestPalindrome = 0;
            
            for (var i = lowerNumber; i <= upperNumber; i++)
            {
                for (var j = upperNumber; j >= lowerNumber; j--)
                {
                    var product = i * j;

                    string reverseProduct = ReverseProduct(product);

                    if (ProductIsPalindromic(product, reverseProduct) &&
                        ProductIsGreaterThanLargestPalindrome(product, largestPalindrome))
                    {
                        largestPalindrome = product;
                    }
                }
            }

            Console.WriteLine("The largest palindrome made from the product of two 3-digit numbers is:  {0}", largestPalindrome);
            Console.ReadLine();
        }

        private static bool ProductIsGreaterThanLargestPalindrome(int product, int largestPalindrome)
        {
            return product > largestPalindrome;
        }

        private static bool ProductIsPalindromic(int product, string reverseProduct)
        {
            return product.ToString() == reverseProduct;
        }

        private static string ReverseProduct(int product)
        {
            var reverse = product.ToString().ToCharArray();
            var reverseResult = new StringBuilder();

            for (var i = reverse.Length-1; i >= 0; i--)
            {
                reverseResult.Append(reverse[i]);
            }
            return reverseResult.ToString();
        }
    }
}
