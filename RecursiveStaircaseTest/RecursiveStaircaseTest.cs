using System;
using Xunit;
using RecursiveStaircase;

namespace RecursiveStaircaseTest
{
    public class RecursiveStaircaseTest
    {
        [Fact]
        public void RecursiveStaircaseSolve_n0Options1n2n3_1()
        {
            int result = RecursiveStaircaseSolution.Solve(0, new int[] { 1, 2, 3 });

            Assert.Equal(1, result);
        }

        [Fact]
        public void RecursiveStaircaseSolve_n1Options1n2n3_1()
        {
            int result = RecursiveStaircaseSolution.Solve(0, new int[] { 1, 2, 3 });

            Assert.Equal(1, result);
        }

        [Fact]
        public void RecursiveStaircaseSolve_n3NoOptions_0()
        {
            int result = RecursiveStaircaseSolution.Solve(3, new int[] {  });

            Assert.Equal(1, result);
        }

        [Fact]
        public void RecursiveStaircaseSolve_n0NoOptions_0()
        {
            int result = RecursiveStaircaseSolution.Solve(0, new int[] { });

            Assert.Equal(1, result);
        }

        [Fact]
        public void RecursiveStaircaseSolve_n4Options1_5()
        {
            int result = RecursiveStaircaseSolution.Solve(4, new int[] { 1, 2 });

            Assert.Equal(5, result);
        }

        [Fact]
        public void RecursiveStaircaseSolve_n5Options1_1()
        {
            int result = RecursiveStaircaseSolution.Solve(5, new int[] { 1 });

            Assert.Equal(1, result);
        }

        [Fact]
        public void RecursiveStaircaseSolve_n4Options1n2_5()
        {
            int result = RecursiveStaircaseSolution.Solve(4, new int[] { 1, 2 });

            Assert.Equal(5, result);
        }

        [Fact]
        public void RecursiveStaircaseSolve_n3Options1n3n5_5()
        {
            int result = RecursiveStaircaseSolution.Solve(3, new int[] { 1, 3, 5 });

            Assert.Equal(2, result);
        }

        [Theory, 
            InlineData(6, new int[] { 4, 1, 3}),
            InlineData(4, new int[] { 2, 1, 3 }),
            InlineData(20, new int[] { 2, 1, 3 }),
            InlineData(30, new int[] { 6, 1, 3, 4, 10 }),
            InlineData(30, new int[] { 6, 1, 3, 4, 10, 9 }),
            InlineData(10, new int[] { 4, 1, 3 })]
        public void RecursiveStaircaseSolve_CompareRecursionVersion_Same(int n, int[] jumps)
        {
            int result = RecursiveStaircaseSolution.Solve(3, new int[] { 1, 3, 5 });
            int expected = RecursiveStaircaseRecursion(3, new int[] { 1, 3, 5 });

            Assert.Equal(expected, result);
        }

        private int RecursiveStaircaseRecursion(int n, int[] jumps)
        {
            if (jumps.Length == 0) return 1;
            if (n == 0) return 1;

            int total = 0;

            foreach (int jump in jumps)
            {
                if (n - jump >= 0)
                {
                    total += RecursiveStaircaseRecursion(n - jump, jumps);
                }                
            }

            return total;
        }
    }
}
