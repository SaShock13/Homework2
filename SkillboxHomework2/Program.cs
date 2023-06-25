using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillboxHomework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName;
            ushort age;
            string email;
            float progScore;
            float mathScore;
            float physScore;
            float totalScore;
            float midScore;

            fullName = "Ломоносов Михаил Васильевич";
            age = 19;
            email = "nos@gmail.com";
            progScore = 3.3F;
            mathScore = 4.7F;
            physScore = 5;
            totalScore = mathScore + physScore + progScore;
            midScore = totalScore / 3;

            WriteLine($"{fullName}\nВозраст: {age} лет, E-mail: {email}\n\nБаллы по математике: {mathScore}\nБаллы по физике: {physScore}\nБаллы по программированию: {progScore}");
            WriteLine($"\nСредний балл : {midScore.ToString("#.##")}");
            ReadKey();

        }
    }
}
