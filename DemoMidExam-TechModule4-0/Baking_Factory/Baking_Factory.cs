using System;
using System.Collections.Generic;
using System.Linq;

namespace Baking_Factory
{
    public class Baking_Factory
    {
        public static void Main()
        {
            List<int> qualities = new List<int>();
            List<double> averages = new List<double>();
            List<int> lengths = new List<int>();
            List<int[]> batchesOfBread = new List<int[]>();

            string batch = Console.ReadLine();
            while (batch != "Bake It!")
            {
                int[] breads = batch.Split('#').Select(int.Parse).ToArray();

                int totalQuality = breads.Sum();
                qualities.Add(totalQuality);

                double average = breads.Average();
                averages.Add(average);

                lengths.Add(breads.Length);
                batchesOfBread.Add(breads);

                batch = Console.ReadLine();
            }

            int maxQualityValue = qualities[0];
            int maxQualityBatchIndex = 0;
            for (int i = 0; i < qualities.Count; i++)
            {
                if (qualities[i] > maxQualityValue)
                {
                    maxQualityValue = qualities[i];
                    maxQualityBatchIndex = i;
                }
                else if (qualities[i] == maxQualityValue)
                {
                    // If there are several batches with same total quality select the batch with the greater
                    // average quality
                    if (averages[i] > averages[maxQualityBatchIndex])
                    {
                        maxQualityBatchIndex = i;
                    }
                    // If there are several batches with same total quality and average quality, take the one
                    // with the fewest elements (length).
                    else if (averages[i] == averages[maxQualityBatchIndex])
                    {
                        if (lengths[i] < lengths[maxQualityBatchIndex])
                        {
                            maxQualityBatchIndex = i;
                        }
                    }
                }
            }

            Console.WriteLine($"Best Batch quality: {qualities[maxQualityBatchIndex]}");
            Console.WriteLine($"{string.Join(' ', batchesOfBread[maxQualityBatchIndex])}");
        }
    }
}
