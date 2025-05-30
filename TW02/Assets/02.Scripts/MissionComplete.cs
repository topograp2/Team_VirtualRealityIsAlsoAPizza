using UnityEngine;
using System.Collections;

public class MissionComplete : MonoBehaviour
{
    [Header("이 씬에 해당하는 미션 번호 (1~5)")]
    public int missionNumber = 1;

    [Header("도감 반짝이 오브젝트")]
    public GameObject sparkleImage;

    void Start()
    {
        SceneTracker.complete = missionNumber;

        if (PlayerPrefs.GetInt("StatusVisited", 0) == 1)
        {
            if (sparkleImage != null)
            {
                sparkleImage.SetActive(false);
                
            }

            
            StartCoroutine(ResetStatusVisitedNextFrame());
        }
    }

    IEnumerator ResetStatusVisitedNextFrame()
    {
        yield return null; // 한 프레임 대기
        PlayerPrefs.SetInt("StatusVisited", 0);
        PlayerPrefs.Save();
        
    }
}


