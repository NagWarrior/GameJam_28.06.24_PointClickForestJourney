using UnityEngine;

public class CardCloser : MonoBehaviour
{
    public GameObject card; // ������ �� ��������

    public void CloseCard()
    {
        if (card != null)
        {
            card.SetActive(false); // ������ ��������
        }
    }
}