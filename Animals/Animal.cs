namespace Animals
{
  public class Animal
  {
    private string _species;
    private double _walkingSpeed;

    public string Name { get; }
    public string Species
    {
      get
      {
        return _species;
      }
    }

    public double WalkingSpeed
    {
      get
      {
        return _walkingSpeed;
      }
    }

    public Animal(string name)
    {
      this.Name = name;
    }

    public void SetSpecies(string species)
    {
      _species = species;
    }

    public void Walk(double speed)
    {
      _walkingSpeed = speed;
    }
  }
}