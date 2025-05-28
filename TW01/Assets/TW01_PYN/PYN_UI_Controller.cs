using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PYN_UI_Controller : MonoBehaviour
{
    public TMP_Text pickCounts;
    public TMP_Text putCounts;

    public void Display_PickCounts(int count){
        pickCounts.text = count.ToString();
    }
    public void Display_PutCounts()
    {
        int lastPutCount = int.Parse(putCounts.text);
        int currentPutCount = lastPutCount +1;
        putCounts.text = currentPutCount.ToString();
    }

    public void Decrease_PickCounts(){
        int lastPickCount = int.Parse(pickCounts.text);
        int currentPickCount = lastPickCount -1;
        pickCounts.text = currentPickCount.ToString();
    }

    public int GetPickCount(){
        int counts = int.Parse(pickCounts.text);
        return counts;
    }


}
