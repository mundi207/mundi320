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
        GameObject temp = Instantiate(Resources.Load("Prefab/TEXT") as GameObject); // temp 인스턴스 변수에 생성한 프리팹 오브젝트 저장
        temp.transform.SetParent(bg.transform); // 캔버스를 부모로 지정

        text = temp.GetComponent<TMP_Text>(); // 해당 오브젝트에 존재하는 텍스트 컴포넌트를 불러옴
        rectTransform = text.GetComponent<RectTransform>(); // 텍스트의 RectTransform 컴포넌트를 불러옴
        Move(); // 메소드 호출 (Move)
    }
    private void Move()
    {
        // Canvas ㅈㄴ크니까 카메라 좌표에서 월드좌표로 변경
        rectTransform.position = Camera.main.WorldToScreenPoint(new Vector3(5, 0, 0)); // Vector3.right * 5, 오른쪽으로 5만큼 이동
    }
}
