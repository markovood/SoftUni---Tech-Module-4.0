using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    public class SoftUni_Course_Planning
    {
        public static void Main()
        {
            List<string> lessonsAndExercises = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x)
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "course start")
                {
                    break;
                }

                string[] commandDetails = command.Split(':');
                switch (commandDetails[0])
                {
                    case "Add":
                        string lessonTitle = commandDetails[1];
                        if (!lessonsAndExercises.Contains(lessonTitle))
                        {
                            lessonsAndExercises.Add(lessonTitle);
                        }
                        break;
                    case "Insert":
                        lessonTitle = commandDetails[1];
                        int index = int.Parse(commandDetails[2]);
                        if (!lessonsAndExercises.Contains(lessonTitle))
                        {
                            lessonsAndExercises.Insert(index, lessonTitle);
                        }
                        break;
                    case "Remove":
                        lessonTitle = commandDetails[1];
                        if (lessonsAndExercises.Contains(lessonTitle))
                        {
                            lessonsAndExercises.Remove(lessonTitle);
                            string exerciseName = $"{lessonTitle}-Exercise";
                            int indexOfExerciseName = lessonsAndExercises.IndexOf(exerciseName);
                            if (indexOfExerciseName >= 0)
                            {
                                lessonsAndExercises.RemoveAt(indexOfExerciseName);
                            }
                        }
                        break;
                    case "Swap":
                        lessonTitle = commandDetails[1];
                        string otherLessonTitle = commandDetails[2];
                        if (lessonsAndExercises.Contains(lessonTitle) &&
                            lessonsAndExercises.Contains(otherLessonTitle))
                        {
                            Swap(lessonsAndExercises, lessonTitle, otherLessonTitle);
                            string firstLessonExerciseName = $"{lessonTitle}-Exercise";
                            string secondLessonExerciseName = $"{otherLessonTitle}-Exercise";
                            if (lessonsAndExercises.Contains(firstLessonExerciseName))
                            {
                                // put it right behind the lesson
                                int indexOfLesson = lessonsAndExercises.IndexOf(lessonTitle);
                                int indexOfExercise = lessonsAndExercises.IndexOf(firstLessonExerciseName);
                                lessonsAndExercises.RemoveAt(indexOfExercise);
                                lessonsAndExercises.Insert(indexOfLesson + 1, firstLessonExerciseName);
                            }

                            if (lessonsAndExercises.Contains(secondLessonExerciseName))
                            {
                                // put it right behind the lesson
                                int indexOfLesson = lessonsAndExercises.IndexOf(otherLessonTitle);
                                int indexOfExercise = lessonsAndExercises.IndexOf(secondLessonExerciseName);
                                lessonsAndExercises.RemoveAt(indexOfExercise);
                                lessonsAndExercises.Insert(indexOfLesson + 1, secondLessonExerciseName);
                            }
                        }
                        break;
                    case "Exercise":
                        lessonTitle = commandDetails[1];
                        bool lessonExists = lessonsAndExercises.Contains(lessonTitle);
                        string exerciseTitle = $"{lessonTitle}-Exercise";
                        bool exerciseExists = lessonsAndExercises.Contains(exerciseTitle);
                        if (lessonExists && !exerciseExists)
                        {
                            int indexOfLesson = lessonsAndExercises.IndexOf(lessonTitle);
                            lessonsAndExercises.Insert(indexOfLesson + 1, exerciseTitle);
                        }
                        else if (!lessonExists)
                        {
                            lessonsAndExercises.Add(lessonTitle);
                            lessonsAndExercises.Add(exerciseTitle);
                        }
                        break;
                }

            }

            int lessonIndex = 1;
            foreach (var item in lessonsAndExercises)
            {
                Console.WriteLine($"{lessonIndex}.{item}");
                lessonIndex++;
            }
        }

        private static void Swap(List<string> courseProgramma, string firstLessonTitle, string secondLessonTitle)
        {
            int firstLessonIndex = courseProgramma.IndexOf(firstLessonTitle);
            int secondLessonIndex = courseProgramma.IndexOf(secondLessonTitle);

            string temp = courseProgramma[firstLessonIndex];
            courseProgramma[firstLessonIndex] = courseProgramma[secondLessonIndex];
            courseProgramma[secondLessonIndex] = temp;
        }
    }
}
