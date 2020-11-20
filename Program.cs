using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanYourHeist
{
  class Program
  {
    static void Main(string[] args)
    {
      //Create a way to store several team members.
      var wholeTeam = new List<TeamMember>();
      var newTeamMember = new TeamMember();

      //Store a value for the bank's difficulty level. Set this value to 100.
      int bankDifficultyLevel = 100;

      //Print the message "Plan Your Heist!".
      Console.WriteLine("Plan Your Heist!");

      //Collect several team members' information.
      Console.Write("Add A New Member? Y/N  ");
      string answer = Console.ReadLine().ToLower();
      Console.WriteLine();
      while (answer == "y")
      {
        newTeamMember = CreateTeamMember();
        //Stop collecting team members when a blank name is entered.
        if (!string.IsNullOrEmpty(newTeamMember.Name))
        {
          wholeTeam.Add(newTeamMember);
          Console.Write("Add A New Member? Y/N  ");
          answer = Console.ReadLine().ToLower();
          Console.WriteLine();
        }
        else
        {
          Console.WriteLine(@"Error Member Must have name try again
          NAMELESS MEMBER WAS NOT ADDED");
        }
      }
      //Display a message containing the number of members of the team.
      // Console.WriteLine($"You Have {wholeTeam.Count} Team Members");
      // wholeTeam.ForEach(member => Console.WriteLine($@"
      //   Name: {member.Name}
      //   Skill Level: {member.SkillLevel}
      //   Courage: {member.Courage}
      //   "));

      //Sum the skill levels of the team. Save that number.
      IEnumerable<int> total = wholeTeam.Select(member => member.SkillLevel);
      int teamTotalSkillLevel = total.Sum();

      //Compare the number with the bank's difficulty level. If the team's skill level is greater than or equal to the bank's difficulty level, Display a success message, otherwise display a failure message.
      if (teamTotalSkillLevel >= bankDifficultyLevel)
      {
        Console.WriteLine("Money! Money! Money! Monday!");
      }
      else
      {
        Console.WriteLine("Being Free anb broke is better than jail and broke.");
      }
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
