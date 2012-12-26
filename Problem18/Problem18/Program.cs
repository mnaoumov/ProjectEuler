using System;
using System.Linq;

namespace Problem18
{
    class Program
    {
        const int Size = 15;

        static void Main(string[] args)
        {
            var str =
@"75
95 64
17 47 82
18 35 87 10
20 04 82 47 65
19 01 23 75 03 34
88 02 77 73 07 63 67
99 65 04 28 06 16 70 92
41 41 26 56 83 40 80 70 33
41 48 72 33 47 32 37 16 94 29
53 71 44 65 25 43 91 52 97 51 14
70 11 33 28 77 73 17 78 39 68 17 57
91 71 52 38 17 14 91 43 58 50 27 29 48
63 66 04 68 89 53 67 30 73 16 69 87 40 31
04 62 98 27 23 09 70 98 73 93 38 53 60 04 23";

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
