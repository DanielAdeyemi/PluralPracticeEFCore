using System.Collections.Generic;

public class Battle
{
  public int BattleId { get; set; }   
  public string Name { get; set; }
  public List<Samurai>Samurais { get; set; } = new List<Samurai>();
}