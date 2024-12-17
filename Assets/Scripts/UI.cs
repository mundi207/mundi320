using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class UI : MonoBehaviour
{
    private TMP_Text text;
    private RectTransform rectTransform;

    [SerializeField]
    private Canvas canvas;
    [SerializeField]
    private GameObject bg;

    private void Start()
    {
        GameObject temp = Instantiate(Resources.Load("Prefab/TEXT") as GameObject); // temp �ν��Ͻ� ������ ������ ������ ������Ʈ ����
        temp.transform.SetParent(bg.transform); // ĵ������ �θ�� ����

        text = temp.GetComponent<TMP_Text>(); // �ش� ������Ʈ�� �����ϴ� �ؽ�Ʈ ������Ʈ�� �ҷ���
        rectTransform = text.GetComponent<RectTransform>(); // �ؽ�Ʈ�� RectTransform ������Ʈ�� �ҷ���
        Move(); // �޼ҵ� ȣ�� (Move)
    }
    private void Move()
    {
        // Canvas ����ũ�ϱ� ī�޶� ��ǥ���� ������ǥ�� ����
        rectTransform.position = Camera.main.WorldToScreenPoint(new Vector3(5, 0, 0)); // Vector3.right * 5, ���������� 5��ŭ �̵�
    }
}
