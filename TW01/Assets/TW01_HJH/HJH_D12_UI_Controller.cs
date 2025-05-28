using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HJH_D12_UI_Controller : MonoBehaviour
{
    public GameObject TimeOutPanel, RetryButton;
    public TMP_Text Heart_PickCounts, Heart_PutCounts, TimerText, TimeOutText;
    int pickCounter, putCounter;

    private float remainingTime = 30f;
    private bool timerRunning = true;

    void Start()
    {
        Heart_PickCounts.text = pickCounter.ToString();
        Heart_PutCounts.text = putCounter.ToString();
        TimerText.text = Mathf.CeilToInt(remainingTime).ToString();
    }

    void Update()
    {
        if (timerRunning)
        {
            remainingTime -= Time.deltaTime;

            if (remainingTime <= 0f)
            {
                remainingTime = 0f;
                timerRunning = false;
                OnTimerEnd();
            }
            TimerText.text = Mathf.CeilToInt(remainingTime).ToString();
        }
    }

    void OnTimerEnd()
    {
        print($"Time Over!");
        TimeOutText.text = $"TIME OVER!\nYou pushed {putCounter} hearts!";
        RetryButton.SetActive(false);
        TimeOutPanel.SetActive(true);
    }

    public void RetryScene()
    {
        // 현재 활성화된 씬을 다시 불러오기
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadHomeScene()
    {
        SceneManager.LoadScene("BY_HomeScene");
    }

    public void Increase_PickCounter()
    {
        print($"increase pickCounter");
        pickCounter ++;
        Heart_PickCounts.text = pickCounter.ToString();
    }

    public void Decrease_PickCounter()
    {
        print($"decrease pickCounter");
        pickCounter--;
        Heart_PickCounts.text = pickCounter.ToString();
    }

    public void Increase_PutCounter()
    {
        print($"increase putCounter");
        putCounter ++;
        Heart_PutCounts.text = putCounter.ToString();
    }


    public int GetPickCounts()
    {
        return pickCounter;
    }
}
