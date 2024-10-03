namespace tetra_master_api.Models
{
  public class Card(int id, string name, string initialStats, bool missable)
  {
    public int Id { get; set; } = id;

    public string Name { get; set; } = name;

    public string InitialStats { get; set; } = initialStats;

    public bool Missable { get; set; } = missable;
  }
}
