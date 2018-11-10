using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    public class Task3
    {
        public static void Main()
        {
            List<string> journal = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Retire!")
                {
                    break;
                }

                string currentCommand = "";
                if (command.StartsWith("Start - ")) // nb remove ' - '
                {
                    currentCommand = "Start";
                }
                else if (command.StartsWith("Complete - "))
                {
                    currentCommand = "Complete";
                }
                else if (command.StartsWith("Side Quest - "))
                {
                    currentCommand = "Side Quest";
                }
                else
                {
                    currentCommand = "Renew";
                }

                switch (currentCommand)
                {
                    case "Start":
                        string[] tokens = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                        string quest = tokens[1];
                        if (!journal.Contains(quest))
                        {
                            journal.Add(quest);
                        }
                        break;
                    case "Complete":
                        tokens = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                        quest = tokens[1];
                        if (journal.Contains(quest))
                        {
                            journal.Remove(quest);
                        }
                        break;
                    case "Side Quest":
                        tokens = command.Split(new char[] { ' ', '-', ':'}, StringSplitOptions.RemoveEmptyEntries);
                        quest = tokens[2];
                        string sideQuest = tokens[tokens.Length - 1];
                        bool questExists = journal.Contains(quest);
                        bool sideQuestExists = journal.Contains(sideQuest);
                        if (questExists && !sideQuestExists)
                        {
                            int questIndex = journal.IndexOf(quest);
                            journal.Insert(questIndex + 1, sideQuest);
                        }
                        break;
                    case "Renew":
                        tokens = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                        quest = tokens[1];
                        if (journal.Contains(quest))
                        {
                            int questIndex = journal.IndexOf(quest);
                            string temp = journal[questIndex];
                            journal.RemoveAt(questIndex);
                            journal.Add(temp);
                        }
                        break;
                }
            }

            string journalStr = string.Join(", ", journal);
            Console.WriteLine(journalStr);
        }
    }
}
