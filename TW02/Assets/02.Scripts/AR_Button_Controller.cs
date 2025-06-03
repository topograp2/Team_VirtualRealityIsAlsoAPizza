using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class AR_Button_Controller : MonoBehaviour
{
    public GameObject Button_Done;  // Inspector���� ��ư ����
    private ObserverBehaviour mObserverBehaviour;
    private bool hasBeenTracked = false;  // ���� �ν� ���� ����

    // Start is called before the first frame update
    void Start()
    {
        mObserverBehaviour = GetComponent<ObserverBehaviour>();
        if (mObserverBehaviour)
        {
            mObserverBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;
        }

        if (Button_Done != null)
            Button_Done.SetActive(false);  // ���� �� ��Ȱ��ȭ
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (Button_Done == null || hasBeenTracked) 
            return;

        if (targetStatus.Status == Status.TRACKED ||
            targetStatus.Status == Status.EXTENDED_TRACKED)
        {
            Button_Done.SetActive(true);  // �νĵǸ� ��ư ǥ��
            hasBeenTracked = true;        // ���� �ٽ� ������ �ʵ��� ����
        }
    }
}
