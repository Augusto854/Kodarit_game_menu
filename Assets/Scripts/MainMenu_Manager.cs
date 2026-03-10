using UnityEngine;

public class MainMenu_Manager : MonoBehaviour
{
    public FadeControl FadeControl;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FadeControl.gameObject.SetActive(true);
        FadeControl.FadeOut();
    }
}
