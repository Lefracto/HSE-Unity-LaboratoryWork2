using UnityEngine;

[CreateAssetMenu(menuName = "Card Asset")]
public class CardAsset : ScriptableObject
{
  [SerializeField] private string _cardName;
  [SerializeField] public Color _cardColor;
  [SerializeField] public Sprite _cardImage;

  public string CardName => _cardName;
  public Color CardColor => _cardColor;
  public Sprite CardImage => _cardImage;
}