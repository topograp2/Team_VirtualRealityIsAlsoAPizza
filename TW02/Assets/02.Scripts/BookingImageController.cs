using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class BookingImageController : MonoBehaviour
{
    public Image uiImage;                // 이미지 UI
    public Sprite image01, image02, image03; // 보여줄 이미지들
    public Button stateButton;           // 상태 변화 버튼
    public TextMeshProUGUI buttonText;  // 버튼 텍스트

    private int state = 1; // 현재 상태를 나타내는 변수

    string nextSceneName = "Mission02_Success"; // 다음 씬 이름

    // Start is called before the first frame update
    void Start()
    {
        // 초기 상태 설정
        uiImage.sprite = image01;
        buttonText.text = "다음";

        // 버튼 클릭 시 ChangeState 함수 실행
        stateButton.onClick.AddListener(ChangeState);
    }

    void ChangeState()
    {
        if (state == 1)
        {
            state = 2;
            uiImage.sprite = image02;
            buttonText.text = "다음";
        }
        else if (state == 2)
        {
            state = 3;
            uiImage.sprite = image03;
            buttonText.text = "완료";
        }
        else if (state == 3)
        {
            SceneManager.LoadScene(nextSceneName); // 완료 버튼 클릭 시 다음 씬으로 이동
        }
    }
}

