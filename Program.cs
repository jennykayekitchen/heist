using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your skill level?");
            int skill = int.Parse(Console.ReadLine());
            Console.WriteLine("On a scale of 0.0 - 2.0, what is your courage factor?");
            double courage = Convert.ToDouble(Console.ReadLine());
            
            TeamMember newMember = new TeamMember(name, skill, courage);

            Console.WriteLine($"{newMember.Name} has a skill level of {newMember.SkillLevel} and a courage factor of {newMember.CourageFactor}.");
        }
    }
}
