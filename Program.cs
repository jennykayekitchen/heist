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
            Dictionary<string, TeamMember> team1 = new Dictionary<string, TeamMember>();

            Bank targetBank = new Bank()
            {
                DifficultyLevel = 100
            };


            string response = "y";

            while (response == "y")
            {

                Console.WriteLine("What is the team member's name?");

                string name = Console.ReadLine();

                // foreach (KeyValuePair<string, TeamMember> t in team1)
                // {
                //     Console.WriteLine(t.Value.Stringify());
                // }
                // break;

                Console.WriteLine($"What is {name}'s skill level?");
                int skill = int.Parse(Console.ReadLine());

                Console.WriteLine($"On a scale of 0.0 - 2.0, what is {name}'s courage factor?");
                double courage = Convert.ToDouble(Console.ReadLine());

                TeamMember newMember = new TeamMember(name, skill, courage);

                //Console.WriteLine($"{newMember.Name} has a skill level of {newMember.SkillLevel} and a courage factor of {newMember.CourageFactor}.");

                team1.Add($"{newMember.Name}", newMember);

                int teamSkillLevel = team1.Sum(x => x.Value.SkillLevel);
                
                if (teamSkillLevel < targetBank.DifficultyLevel)
                {
                    Console.WriteLine($"Based on your current team of {team1.Count} and combined skill level of {teamSkillLevel}, your heist will FAIL.");
                }

                else
                {
                    Console.WriteLine($"Based on your current team of {team1.Count} and combined skill level of {teamSkillLevel}, your heist will SUCCEED.");
                }

                Console.WriteLine("Would you like to enter another team member? Y/N:");
                response = Console.ReadLine().ToLower();

            }



        }
    }
}
