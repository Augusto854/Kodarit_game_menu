using System.Linq;
using TMPro;
using UnityEngine;

public class Selection : MonoBehaviour
{
    public Color normalColor = Color.white;

    public Color selectColor = Color.yellow;

    public TMP_Text[] items; //meidän napit listassa
    public Color[] colors;
    private int index = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ChangeColors();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            index = (index - 1 + items.Length) % items.Length;
            ChangeColors();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            index = (index + 1) % items.Length;
            ChangeColors();
        } 
    }

    void ChangeColors()
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (i == index)
            {
                items[i].color = colors[i];
            }
            else
            {
                items[i].color = normalColor;
            }
        }
    }
}
