using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
  class Program
  {
    static void Main(string[] args)
    {
      //Create a way to store several team members.
      var wholeTeam = new List<TeamMember>();
      var newTeamMember = new TeamMember();

      //Print the message "Plan Your Heist!".
      Console.WriteLine("Plan Your Heist!");

      //Collect several team members' information.
      Console.Write("Add A New Member? Y/N  ");
      string answer = Console.ReadLine().ToLower();
      while (answer == "y")
      {
        newTeamMember = CreateTeamMember();
        wholeTeam.Add(newTeamMember);
        Console.Write("Add A New Member? Y/N  ");
        answer = Console.ReadLine().ToLower();
      }
      //Display a message containing the number of members of the team.
      Console.WriteLine($"You Have {wholeTeam.Count} Team Members");
      wholeTeam.ForEach(member => Console.WriteLine($@"
        Name: {member.Name}
        Skill Level: {member.SkillLevel}
        Courage: {member.Courage}
        "));
    }

    static TeamMember CreateTeamMember()
    {
      //Prompt the user to enter a team member's name and save that name.
      Console.Write("Enter Team Member Name:  ");
      string name = Console.ReadLine();
      //Prompt the user to enter a team member's skill level and save that skill level with the name.
      Console.Write($"Enter {name}'s Skill Level:  ");
      int skillLevel = int.Parse(Console.ReadLine());
      //Prompt the user to enter a team member's courage factor and save that courage factor with the name.
      Console.Write($"Enter {name}'s courage factor:  ");
      decimal courage = decimal.Parse(Console.ReadLine());
      return new TeamMember
      {
        Name = name,
        SkillLevel = skillLevel,
        Courage = courage
      };
    }
  }
}
