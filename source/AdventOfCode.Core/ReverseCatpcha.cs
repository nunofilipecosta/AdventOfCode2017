using System;

namespace AdventOfCode.Core
{
    public class ReverseCatpcha
    {
        public int Solve(string sequence)
        {
            var sequenceArray = sequence.ToCharArray();
            var sum = 0;

            for (int i = 0; i < sequenceArray.Length; i++)
            {
                var current = Convert.ToInt32(sequenceArray[i].ToString());

                var nextIndex = i + 1;

                if(nextIndex >= sequenceArray.Length)
                {
                    nextIndex = 0;
                }

                var next = Convert.ToInt32(sequenceArray[nextIndex].ToString());
                
                if(current == next)
                {
                    sum += current;
                }
            }

            return sum;
        }
    }
}
