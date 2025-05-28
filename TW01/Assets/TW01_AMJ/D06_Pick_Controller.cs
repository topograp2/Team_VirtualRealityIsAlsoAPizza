﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class D06_Pick_Controller : MonoBehaviour
{
    public TMP_Text PickCounts;             // Step04
    public TMP_Text PutCounts;              // Step05
    int clickCounter = 0;   // 클릭한 클론의 수
    public GameObject UI;   // Step04 (UI 관련 스크립트를 갖고 있는 게임 오브젝트)

    // clickCounter의 값을 1씩 증가시키는 함수
    public void Add_Click(GameObject Clone)
    {
        clickCounter++;
        print($"{clickCounter} 개의 클론을 클릭했습니다.");
        Destroy(Clone);

        int lastPickCount = int.Parse(PickCounts.text);
        int currentPickCount = lastPickCount + 1;
        PickCounts.text = currentPickCount.ToString();
        // Step04 (UI에 내용을 표시하는 스크립트 호출)
        UI.GetComponent<D06_UI_Controller>().Display_PickCounts(currentPickCount);
    }
}
