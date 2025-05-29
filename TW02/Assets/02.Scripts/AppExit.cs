using UnityEngine;

public class AppExit : MonoBehaviour
{
    public void QuitApp()
    {
        Debug.Log("앱 종료 시도됨");  // PC에서는 작동 안 할 수 있어서 로그로 확인
        Application.Quit();
    }
}

