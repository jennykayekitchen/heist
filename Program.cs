using System;
using System.Collections.Generic;
using System.Linq;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            Bank targetBank = new Bank()
            {
                DifficultyLevel = 100
            };

            Console.WriteLine("Enter the bank's difficulty level (0 - 100).");
            targetBank.DifficultyLevel = int.Parse(Console.ReadLine());       

            Dictionary<string, TeamMember> team1 = new Dictionary<string, TeamMember>();
            string name = "YOUR MOM";

            while (name != "")
            {

                Console.WriteLine("What is the team member's name? (Press enter to stop entering names and start a trial run.)");
                name = Console.ReadLine();

                if (name == "")
                {
                    continue;
                }

                // foreach (KeyValuePair<string, TeamMember> t in team1)
                // {
                //     Console.WriteLine(t.Value.Stringify());
                // }

                Console.WriteLine($"What is {name}'s skill level (1 - 100)?");
                int skill = int.Parse(Console.ReadLine());

                Console.WriteLine($"What is {name}'s courage factor (0.0 - 2.0)?");
                double courage = Convert.ToDouble(Console.ReadLine());

                TeamMember newMember = new TeamMember(name, skill, courage);

                //Console.WriteLine($"{newMember.Name} has a skill level of {newMember.SkillLevel} and a courage factor of {newMember.CourageFactor}.");

                team1.Add($"{newMember.Name}", newMember);


            }
            Console.WriteLine("How many trial runs would you like to perform?");
            int trialRuns = int.Parse(Console.ReadLine());

            int failedRuns = 0;
            int succeededRuns = 0;
            for (int i = 1; i <= trialRuns; i++)
            {
                int teamSkillLevel = team1.Sum(x => x.Value.SkillLevel);
                Random r = new Random();
                int luck = r.Next(-10, 11);
                targetBank.DifficultyLevel = luck + targetBank.DifficultyLevel;
                //Console.WriteLine($"Trial run #{i}: Based on your current team of {team1.Count}, your combined skill level is: {teamSkillLevel}. The bank's difficulty level is: {targetBank.DifficultyLevel}.");

                if (teamSkillLevel < targetBank.DifficultyLevel)
                {
                    failedRuns++;
                    //Console.WriteLine("Your heist will FAIL.");
                }

                else
                {
                    succeededRuns++;
                    //Console.WriteLine("Your heist will SUCCEED.");
                }
            }
                    Console.WriteLine($"{succeededRuns} heists will SUCCEED.");    
                    Console.WriteLine($"{failedRuns} heists will FAIL.");





        }
    }
}
