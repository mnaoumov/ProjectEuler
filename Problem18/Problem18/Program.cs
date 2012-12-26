using System;
using System.Linq;

namespace Problem18
{
    class Program
    {
        const int Size = 4;

        static void Main(string[] args)
        {
            var str =
@"3
7   4
2   4   6
8   5   9   3";

            var tree = PrepareTree(str);

            var maxSubsums = new int[Size, Size];

            for (int level = 0; level < Size; level++)
            {
                for (int index = 0; index <= level; index++)
                {
                    maxSubsums[level, index] = Math.Max(GetTreeValue(maxSubsums, level - 1, index - 1), GetTreeValue(maxSubsums, level - 1, index)) + tree[level, index];
                }
            }

            var max = 0;

            for (int index = 0; index < Size; index++)
            {
                var nodeMax = maxSubsums[Size - 1, index];
                if (nodeMax > max)
                    max = nodeMax;
            }

            Console.WriteLine(max);
        }

        static int GetTreeValue(int[,] tree, int level, int index)
        {
            if (level < 0 || index < 0 || index > level)
                return 0;
            return tree[level, index];
        }

        static int[,] PrepareTree(string str)
        {
            var tree = new int[Size, Size];

            var level = 0;
            foreach (var line in str.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
            {
                var numbers = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => Convert.ToInt32(s));
                var index = 0;
                foreach (var number in numbers)
                {
                    tree[level, index] = number;
                    index++;
                }
                level++;
            }

            return tree;
        }
    }
}
