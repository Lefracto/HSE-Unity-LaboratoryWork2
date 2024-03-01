using UnityEngine;

namespace Core
{
  public class CardView : MonoBehaviour
  {
    private CardInstance _cardInstance;

    public void Init(CardInstance instance)
    {
      _cardInstance = instance;
    }

  }
}