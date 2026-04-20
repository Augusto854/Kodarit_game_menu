using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ReturnButton : MonoBehaviour, IPointerClickHandler
{
    public string targetScene = "GameMenu";

    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene(targetScene);
    }
}
