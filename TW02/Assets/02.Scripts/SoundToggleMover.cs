using UnityEngine;
using UnityEngine.EventSystems;

public class SoundToggleMover : MonoBehaviour, IPointerClickHandler
{
    private bool isAtRight;

    void Start()
    {
        isAtRight = PlayerPrefs.GetInt("SoundOn", 1) == 1;

        // 위치 및 볼륨 설정
        float xPos = isAtRight ? 85f : -85f;
        transform.localPosition = new Vector3(xPos, transform.localPosition.y, transform.localPosition.z);
        AudioListener.volume = isAtRight ? 1f : 0f;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        isAtRight = !isAtRight;

        // 위치 및 소리 토글
        float newX = isAtRight ? 85f : -85f;
        transform.localPosition = new Vector3(newX, transform.localPosition.y, transform.localPosition.z);
        AudioListener.volume = isAtRight ? 1f : 0f;

        // 상태 저장
        PlayerPrefs.SetInt("SoundOn", isAtRight ? 1 : 0);
        PlayerPrefs.Save();

        Debug.Log("소리: " + (isAtRight ? "ON 🔊" : "OFF 🔇"));
    }
}

