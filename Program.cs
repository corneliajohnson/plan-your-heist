using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
  class Program
  {
    static void Main(string[] args)
    {
      TeamMember newMember = CreateTeamMember();
      //Create a way to store several team members.
      var wholeTeam = new List<TeamMember>();
      wholeTeam.Add(newMember);

      wholeTeam.ForEach(member => Console.WriteLine($@"
        Name: {member.Name}
        Skill Level: {member.SkillLevel}
        Courage: {member.Courage}
        "));
    }

    static TeamMember CreateTeamMember()
    {
      //Print the message "Plan Your Heist!".
      Console.WriteLine("Plan Your Heist!");
      //Prompt the user to enter a team member's name and save that name.
      Console.Write("Enter Team Memebr Name: ");
      string name = Console.ReadLine();
      //Prompt the user to enter a team member's skill level and save that skill level with the name.
      Console.Write($"Enter {name}'s Skill Level: ");
      int skillLevel = int.Parse(Console.ReadLine());
      //Prompt the user to enter a team member's courage factor and save that courage factor with the name.
      Console.Write($"Enter {name}'s courage factor: ");
      decimal courage = decimal.Parse(Console.ReadLine());

      return new TeamMember(name, skillLevel, courage);
    }
  }
}
