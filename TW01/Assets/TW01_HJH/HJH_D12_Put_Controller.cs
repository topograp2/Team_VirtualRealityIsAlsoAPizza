using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HJH_D12_Put_Controller : MonoBehaviour
{
    bool isInTheArea;
    public GameObject Bowl;
    public GameObject TargetObjectToClone;
    public Transform PlayerCamera;
    public GameObject UI_Controller;

    void Start()
    {
        Bowl.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isInTheArea)
        {
            HJH_D12_UI_Controller UI_Script = UI_Controller.GetComponent<HJH_D12_UI_Controller>();
            int heartsPicked = UI_Script.GetPickCounts();
            if (heartsPicked > 0)
            {
                ThrowHeart();
            }
            else
            {
                print("collect more hearts");
            }
        }       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "FPSController")
        {
            isInTheArea = true;
            Bowl.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "FPSController")
        {
            isInTheArea = false;
            Bowl.SetActive(false);
        }
    }

    void ThrowHeart()
    {
        // UI�� heart ���� ����
        UI_Controller.GetComponent<HJH_D12_UI_Controller>().Decrease_PickCounter();

        Vector3 Pos = PlayerCamera.position + PlayerCamera.forward;
        Quaternion Rot = Quaternion.Euler(PlayerCamera.forward);

        // heart(Clone) ����
        GameObject Clone = Instantiate(TargetObjectToClone, Pos, Rot);
        Clone.SetActive(true);  // ���� �� �ٷ� Ȱ��ȭ

        // Collider ����: isTrigger�� false�� �����Ͽ� �浹�� �߻��ϵ���
        Clone.GetComponent<Collider>().isTrigger = false;

        // Rigidbody ����: useGravity�� true�� �Ͽ� ������ ���� �޵���
        Clone.GetComponent<Rigidbody>().useGravity = true;

        // ī�޶� �������� ���� �־� ������
        Clone.GetComponent<Rigidbody>().AddForce(PlayerCamera.forward * 400f);
    }
}
