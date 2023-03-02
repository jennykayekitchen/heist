using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("What is your name?");
            TeamMember theTeamMember = new TeamMember(Console.ReadLine(), teamMemberSkill, teamMemberCourage);

            
        }
    }
}
