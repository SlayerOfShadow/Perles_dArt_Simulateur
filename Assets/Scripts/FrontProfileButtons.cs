using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrontProfileButtons : MonoBehaviour
{
    Outline outline;

    private void Start()
    {
        outline = GetComponent<Outline>();
    }

    void OnDisable()
    {
        if (name == "Face")
        {
            outline.enabled = false;
        }
        else
        {
            outline.enabled = true;
        }
    }
}
