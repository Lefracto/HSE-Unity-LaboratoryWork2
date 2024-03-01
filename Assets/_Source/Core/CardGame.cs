using System.Collections.Generic;

namespace Core
{
  public class CardGame
  {
    private static CardGame Instance { get; set; }
    private Dictionary<CardInstance, CardView> _cardMap = new ();
    public List<CardAsset> StartingCards; 
  }
}