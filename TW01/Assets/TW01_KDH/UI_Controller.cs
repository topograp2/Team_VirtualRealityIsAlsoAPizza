using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Controller : MonoBehaviour
{
    public TMP_Text PickCounts;             
    public TMP_Text PutCounts;              
    public GameObject noticeText;

    void Start()
    {
        StartCoroutine(ShowNoticeOnStart());
    }

    IEnumerator ShowNoticeOnStart()
    {
        noticeText.SetActive(true);     
        yield return new WaitForSeconds(3f);
        noticeText.SetActive(false);    
    }


    public void Display_PickCounts(int count)
    {
        PickCounts.text = count.ToString();
    }

    public void Display_PutCounts()
    {
        int lastPutCount = int.Parse(PutCounts.text);
        int currentPutCount = lastPutCount + 1;
        PutCounts.text = currentPutCount.ToString();
    }

    public void Decrease_PickCounts()
    {
        int lastPickCount = int.Parse(PickCounts.text);
        int currentPickCount = lastPickCount - 1;
        PickCounts.text = currentPickCount.ToString();
    }

    public int GetPickCounts()
    {
        int pickCounts = int.Parse(PickCounts.text);
        return pickCounts;
    }
}
