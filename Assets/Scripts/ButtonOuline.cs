using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOuline : MonoBehaviour
{
    [SerializeField]
    List<Outline> buttons_outlines;
    Outline outline;

    void Start()
    {
        outline = GetComponent<Outline>();
    }

    public void set_poses_outlines()
    {
        foreach (Outline o in buttons_outlines)
        {
            o.enabled = false;
        }
        outline.enabled = true;
    }

    public void set_jewels_outlines()
    {
        if (outline.enabled == true)
        {
            outline.enabled = false;
        } else
        {
            foreach (Outline o in buttons_outlines)
            {
                o.enabled = false;
            }
            outline.enabled = true;
        }
        
    }
}
