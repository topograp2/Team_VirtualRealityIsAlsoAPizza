using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using TMPro;

public class MenuButtonHandler : MonoBehaviour, IPointerClickHandler
{
    public enum ButtonType { Setting, Status }
    public ButtonType buttonType;

    public GameObject sparkleImage;

    private bool statusChecked = false;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (buttonType == ButtonType.Setting)
        {
            SceneTracker.previousScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene("SC02_Setting");
        }
        else if (buttonType == ButtonType.Status)
        {
            PlayerPrefs.SetInt("StatusVisited", 1);
            SceneTracker.previousScene = SceneManager.GetActiveScene().name;
            PlayerPrefs.Save();
            SceneManager.LoadScene("SC03_Status");
        }
    }

    void LateUpdate()
    {
        // 딱 한 번만 처리
        if (statusChecked) return;

        if (buttonType == ButtonType.Status)
        {
            int visited = PlayerPrefs.GetInt("StatusVisited", 0);
            Debug.Log($"[MenuButtonHandler] StatusVisited = {visited}");

            if (visited == 1 && sparkleImage != null)
            {
                sparkleImage.SetActive(false);
            }
        }

        statusChecked = true;
    }
}
