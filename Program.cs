using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Dictionary<string, TeamMember> team1 = new Dictionary<string, TeamMember>();
            string response = "y";

            while (response == "y")
            {

                Console.WriteLine("What is the team member's name?");

                string name = Console.ReadLine();

                if (name == "")
                {
                    Console.WriteLine($"Team count: {team1.Count}");

                    foreach (KeyValuePair<string, TeamMember> t in team1)
                    {
                        Console.WriteLine(t.Value.Stringify());
                    }
                    break;
                }
                else
                {
                    Console.WriteLine($"What is {name}'s skill level?");
                    int skill = int.Parse(Console.ReadLine());

                    Console.WriteLine($"On a scale of 0.0 - 2.0, what is {name}'s courage factor?");
                    double courage = Convert.ToDouble(Console.ReadLine());

                    TeamMember newMember = new TeamMember(name, skill, courage);

                    Console.WriteLine($"{newMember.Name} has a skill level of {newMember.SkillLevel} and a courage factor of {newMember.CourageFactor}.");

                    team1.Add($"{newMember.Name}", newMember);


                    Console.WriteLine("Would you like to enter another team member? Y/N:");
                    response = Console.ReadLine().ToLower();
                }
            }

            
        }
    }
}
