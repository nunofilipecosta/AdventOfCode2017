using System;
using System.Collections.Generic;

namespace AdventOfCode.Core.Day2
{
    public class ChecksumCalculator
    {
        public ChecksumCalculator()
        {
        }

        public int Calculate(List<Row> sheet)
        {
            var checksum = 0;
            foreach (var row in sheet)
            {
                var min = row.Numbers[0];
                var max = row.Numbers[0];
                foreach (var number in row.Numbers)
                {
                    if (number < min)
                    {
                        min = number;
                    }

                    if (number > max)
                    {
                        max = number;
                    }
                }

                checksum += (max - min);
            }

            return checksum;
        }
    }
}