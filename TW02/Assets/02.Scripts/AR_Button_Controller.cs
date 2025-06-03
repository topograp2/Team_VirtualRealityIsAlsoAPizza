using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class AR_Button_Controller : MonoBehaviour
{
    public GameObject Button_Done;  // Inspector에서 버튼 연결
    private ObserverBehaviour mObserverBehaviour;
    private bool hasBeenTracked = false;  // 최초 인식 여부 저장

    // Start is called before the first frame update
    void Start()
    {
        mObserverBehaviour = GetComponent<ObserverBehaviour>();
        if (mObserverBehaviour)
        {
            mObserverBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;
        }

        if (Button_Done != null)
            Button_Done.SetActive(false);  // 시작 시 비활성화
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (Button_Done == null || hasBeenTracked) 
            return;

        if (targetStatus.Status == Status.TRACKED ||
            targetStatus.Status == Status.EXTENDED_TRACKED)
        {
            Button_Done.SetActive(true);  // 인식되면 버튼 표시
            hasBeenTracked = true;        // 이후 다시 숨기지 않도록 설정
        }
    }
}
