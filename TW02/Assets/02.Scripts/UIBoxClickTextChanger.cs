using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems; 
using TMPro; 

public class UIBoxClickTextChanger : MonoBehaviour, IPointerClickHandler
{
    public TextMeshProUGUI textUI;
    public string[] texts;
    public string nextSceneName;

    private int currentIndex = 0;

    void Start() {
    if (texts.Length > 0) {
        textUI.text = texts[0];  
        currentIndex = 1;        
    }
}

    public void OnPointerClick(PointerEventData eventData)
    {
        if (currentIndex < texts.Length)
        {
            textUI.text = texts[currentIndex];
            currentIndex++;
        }
        else
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
