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

      //Create a random number between -10 and 10 for the heist's luck value.
      var luckValue = new Random().Next(-10, 11);

      //Print the message "Plan Your Heist!".
      Console.WriteLine("Plan Your Heist!");
      Console.WriteLine();

      //Store a value for the bank's difficulty level
      Console.Write("Enter bank's difficulty level:  ");
      int bankDifficultyLevel = int.Parse(Console.ReadLine());

      //Store a value trial runs
      Console.Write("Enter the number of trial runs the program should perform:  ");
      int trailRuns = int.Parse(Console.ReadLine());
      int count = 0;
      int successfulRun = 0;
      int failedRun = 0;
      while (count < trailRuns)
      {
        //Collect several team members' information.
        wholeTeam.Clear(); // clear for new team
        Console.WriteLine();
        Console.WriteLine($"New Trail Run");
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
            Console.WriteLine();
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

        //Sum the skill levels of the team. Save that number.
        IEnumerable<int> total = wholeTeam.Select(member => member.SkillLevel);
        int teamTotalSkillLevel = total.Sum();

        //Before displaying the success or failure message, display  team's combined skill level and bank's difficulty level
        Console.WriteLine($"Team Cobined Skill Level: {teamTotalSkillLevel}");
        Console.WriteLine($"Bank Difficulty Level: { bankDifficultyLevel + luckValue}");

        //Compare the number with the bank's difficulty level. If the team's skill level is greater than or equal to the bank's difficulty level, Display a success message, otherwise display a failure message.
        if (teamTotalSkillLevel >= bankDifficultyLevel + luckValue)
        {
          Console.WriteLine("Money! Money! Money! Monday!");
          successfulRun++;
        }
        else
        {
          Console.WriteLine("Being Free anb broke is better than jail and broke.");
          failedRun++;
        }
        count++;
      }
      Console.WriteLine($@"
      Sucessful Runs: {successfulRun}
      Failed Runs: {failedRun}");
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
