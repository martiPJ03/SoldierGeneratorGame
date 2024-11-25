using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;  // Required for IPointerDownHandler and IPointerUpHandler

public class ChangeColorDarker : MonoBehaviour
{
    public float darkenFactor = 0.5f; // The factor to darken the color (less than 1 to darken)
    public bool dark = false;
    private Color darkColor;
    private Color normalColor;
    SkinnedMeshRenderer skMeshRenderer;
    public Mybutton button;

    private void Start()
    {
        skMeshRenderer = GetComponent<SkinnedMeshRenderer>();
        normalColor = skMeshRenderer.material.color;
        darkColor = new Color(normalColor.r * darkenFactor, normalColor.g * darkenFactor, normalColor.b * darkenFactor, normalColor.a);
    }

    void Update()
    {
        // Update the color based on the dark boolean
        if (button.buttonPressed)
        {
            skMeshRenderer.material.color = darkColor;
        }
        else
        {
            skMeshRenderer.material.color = normalColor;
        }
    }

}
