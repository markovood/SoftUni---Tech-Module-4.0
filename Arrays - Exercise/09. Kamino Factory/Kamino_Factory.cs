using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Kamino_Factory
{
    public class Kamino_Factory
    {
        public static void Main()
        {
            int sampleLength = int.Parse(Console.ReadLine());
            string sequence = Console.ReadLine();


            List<string> allSamples = new List<string>();
            List<string> longestSubseqPerSample = new List<string>();
            List<int> indexesOflongestSubseqPerSample = new List<int>();
            while (sequence != "Clone them!")
            {
                string[] seqAsArr = sequence.Split('!', StringSplitOptions.RemoveEmptyEntries);
                // save the sample itself
                allSamples.Add(string.Join(' ', seqAsArr));

                // find the longest subsequence in every current sample
                string longestSubsequence = GetLongestSubSequence(seqAsArr);
                longestSubseqPerSample.Add(longestSubsequence);

                // save the index where the longest subsequence starts
                SaveIndexToAList(seqAsArr, longestSubsequence, indexesOflongestSubseqPerSample);

                sequence = Console.ReadLine();
            }

            string bestSample = GetBestSample(allSamples, longestSubseqPerSample, indexesOflongestSubseqPerSample);

            int bestSampleIndex = allSamples.IndexOf(bestSample);
            int bestSampleSum = CalculateSampleSum(allSamples[bestSampleIndex]);

            Console.WriteLine($"Best DNA sample {bestSampleIndex + 1} with sum: {bestSampleSum}.");
            Console.WriteLine($"{allSamples[bestSampleIndex]}");

        }

        private static string GetBestSample(List<string> allSamples, List<string> longestSubsequences, List<int> indexesOflongestSubseqs)
        {
            // find the best from all samples and return it 

            string bestSample = string.Empty;
            string bestSequence = string.Empty;
            int bestSequenceIndex = 0;

            for (int i = 0; i < longestSubsequences.Count; i++)
            {
                if (longestSubsequences[i].Length > bestSequence.Length)
                {
                    bestSequence = longestSubsequences[i];
                    bestSequenceIndex = indexesOflongestSubseqs[i];
                    bestSample = allSamples[i];
                }
                else if (longestSubsequences[i].Length == bestSequence.Length)
                {
                    // check for smaller index
                    if (indexesOflongestSubseqs[i] < bestSequenceIndex)
                    {
                        // take the one with smaller index
                        bestSequenceIndex = indexesOflongestSubseqs[i];
                        bestSequence = longestSubsequences[i];
                        bestSample = allSamples[i];
                    }
                    // check if indexes are '=='
                    else if (indexesOflongestSubseqs[i] == bestSequenceIndex)
                    {
                        // set bestSample to the sample with bigger sum
                        string currentSample = allSamples[i];
                        int currentSampleSum = CalculateSampleSum(currentSample);
                        int bestSampleSum = CalculateSampleSum(bestSample);
                        if (currentSampleSum > bestSampleSum)
                        {
                            bestSample = currentSample;
                        }
                    }
                }
            }

            return bestSample;
        }

        private static void SaveIndexToAList(string[] sequence, string longestSubsequence, List<int> indexes)
        {
            string sequenceAsStr = string.Join("", sequence);
            int longestSeqIndex = sequenceAsStr.IndexOf(longestSubsequence);
            indexes.Add(longestSeqIndex);
        }

        private static string GetLongestSubSequence(string[] seqAsArr)
        {
            int longestSeqLength = 1;
            int currentLength = 0;
            for (int i = 0; i < seqAsArr.Length; i++)// 10110
            {
                if (seqAsArr[i] == "1")
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > longestSeqLength)
                    {
                        longestSeqLength = currentLength;
                    }

                    currentLength = 0;
                }
            }

            // return a sequence of ones based on longestSeqLength
            return new string('1', longestSeqLength);
        }

        private static int CalculateSampleSum(string sample)
        {
            // find the sum of all elements 
            int sum = 0;
            foreach (var item in sample)
            {
                if (item == '1')
                {
                    sum++;
                }
            }

            return sum;
        }
    }
}
