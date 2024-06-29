using UnityEngine;
using UnityEngine.UI;

public class CardOpener : MonoBehaviour
{
    public GameObject card; // ������ �� ��������

    void Start()
    {
        if (card != null)
        {
            card.SetActive(false); // ���������, ��� �������� ������ ��� ������
        }
    }

    void OnMouseDown()
    {
        if (card != null)
        {
            card.SetActive(true); // �������� �������� ��� ������� �� ������
        }
    }
}