using System;

namespace PlanYourHeist
{
  class Program
  {
    static void Main(string[] args)
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

      CreateTeamMember(name, skillLevel, courage);

    }

    static void CreateTeamMember(string name, int skillLevel, decimal courage)
    {
      new TeamMember()
      {
        Name = name,
        SkillLevel = skillLevel,
        Courage = courage
      };

      //display on screen 
      Console.WriteLine($@"
      Name: {name}
      Skill Level: {skillLevel}
      Courage Factor: {courage}");
    }
  }
}
