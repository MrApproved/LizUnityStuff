using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanging : MonoBehaviour
{
    // https://stackoverflow.com/questions/34447682/what-is-the-difference-between-update-fixedupdate-in-unity
    public bool UpdateColourChange;
    public bool FixedUpdateColourChange;

    private Renderer Renderer { get; set; }
    private Color CurrentColor { get; set; }

  
    void Awake()
    {
        Renderer = this.gameObject.GetComponent<Renderer>();
        CurrentColor = new Color(0, 0, 0);
    }

    void Update()
    {
        if (UpdateColourChange)
        {
            CurrentColor += new Color(0.01f, 0.01f, 0.01f);
        }
    }

    void FixedUpdate()
    {
        if(FixedUpdateColourChange)
        {
            CurrentColor += new Color(0.01f, 0.01f, 0.01f);
        }

        if(CurrentColor.r > 1f || CurrentColor.g > 1f || CurrentColor.b > 1f)
        {
            CurrentColor = new Color();
        }

        Renderer.material.color = CurrentColor;
    }
}
