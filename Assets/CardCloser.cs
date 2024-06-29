using UnityEngine;

public class CardCloser : MonoBehaviour
{
    public GameObject card; // —сылка на карточку

    public void CloseCard()
    {
        if (card != null)
        {
            card.SetActive(false); // —крыть карточку
        }
    }
}