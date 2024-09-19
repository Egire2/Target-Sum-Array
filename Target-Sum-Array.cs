using System;
using System.Collections.Generic;


namespace Task
{
    class TargetSumArray
    {
        private Dictionary<int, int> cachNamber = new();
        public (int, int) GetIndiciesOfNumsThatSumToTarget(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int component = target - array[i];
                if (cachNamber.ContainsKey(component))
                {
                    return (cachNamber[component], i);
                }
                cachNamber.Add(array[i], i);
            }
            throw new ArgumentException("There are no elements whose sum is equal to the target");
        }
    }
}
