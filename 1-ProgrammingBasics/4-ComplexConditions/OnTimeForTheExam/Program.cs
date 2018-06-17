using System;

namespace OnTimeForTheExam
{
    class OnTimeForTheExam
    {
        static void Main()
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minuteExam = int.Parse(Console.ReadLine());
            int hourStudentArrival = int.Parse(Console.ReadLine());
            int minuteStudentArrival = int.Parse(Console.ReadLine());

            var hourExamInMinutes = hourExam * 60;
            var totalMinutesExam = hourExamInMinutes + minuteExam;

            var hourStudentArrivalInMinutes = hourStudentArrival * 60;
            var totalMinutesStudentArrival = hourStudentArrivalInMinutes + minuteStudentArrival;

            if (totalMinutesExam < totalMinutesStudentArrival)
            {
                Console.WriteLine("Late");

                if (totalMinutesExam + 59 >= totalMinutesStudentArrival)
                {
                    Console.WriteLine($"{totalMinutesStudentArrival - totalMinutesExam} minutes after the start");
                }
                else if (totalMinutesExam + 60 <= totalMinutesStudentArrival)
                {
                    var result = totalMinutesStudentArrival - totalMinutesExam;
                    Console.WriteLine("{0}:{1:00} hours after the start", result / 60, result % 60);
                }
            }
            else if (totalMinutesExam == totalMinutesStudentArrival)
            {
                Console.WriteLine("On time");
            }
            else if (totalMinutesExam > totalMinutesStudentArrival)
            {
                if (totalMinutesExam - 30 <= totalMinutesStudentArrival)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{totalMinutesExam - totalMinutesStudentArrival} minutes before the start");
                }
                else if (totalMinutesExam - 59 <= totalMinutesStudentArrival)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{totalMinutesExam - totalMinutesStudentArrival} minutes before the start");
                }
                else
                {
                    Console.WriteLine("Early");
                    var result = totalMinutesExam - totalMinutesStudentArrival;
                    Console.WriteLine("{0}:{1:00} hours before the start", result / 60, result % 60);
                }
            }
        }
    }
}
