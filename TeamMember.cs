// Create a way to store a single team member. A team member will have a name, a skill Level and a courage factor. The skill Level will be a positive integer and the courage factor will be a decimal between 0.0 and 2.0.

namespace PlanYourHeist
{
  public class TeamMember
  {
    public string Name;
    public int SkillLevel;
    public decimal Courage;

    public TeamMember(string name, int skilllevel, decimal courage)
    {
      Name = name;
      SkillLevel = skilllevel;
      Courage = courage;
    }
  }
}