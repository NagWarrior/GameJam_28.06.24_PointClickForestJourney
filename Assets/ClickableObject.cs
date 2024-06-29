using UnityEngine;
using UnityEngine.UI;

public class CardOpener : MonoBehaviour
{
    public GameObject card; // Ссылка на карточку

    void Start()
    {
        if (card != null)
        {
            card.SetActive(false); // Убедитесь, что карточка скрыта при старте
        }
    }

    void OnMouseDown()
    {
        if (card != null)
        {
            card.SetActive(true); // Показать карточку при нажатии на объект
        }
    }
}