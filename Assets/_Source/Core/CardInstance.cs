using UnityEngine;

public class CardInstance
{
  public CardAsset CardAsset { get; private set; }

  public CardInstance(CardAsset asset)
  {
    CardAsset = asset;
  }
  
}