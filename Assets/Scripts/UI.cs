using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField]
    GameObject model;
    Renderer model_renderer;

    [SerializeField]
    List<GameObject> panels, sub_panels;

    void Start()
    {
        model_renderer = model.GetComponent<Renderer>();
    }

    public void change_model_material(Material material)
    {
        model_renderer.material = material;
    }

    public void toggle_panel(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
    }

    public void set_active_panel(GameObject panel)
    {
        toggle_panel(panel);
        foreach (GameObject p in panels)
        {
            if (p != panel) p.SetActive(false);
        }
        foreach (GameObject p in sub_panels)
        {
            p.SetActive(false);
        }
    }

    public void set_active_sub_panel(GameObject sub_panel)
    {
        toggle_panel(sub_panel);
        foreach (GameObject p in sub_panels)
        {
            if (p != sub_panel) p.SetActive(false);
        }
    }
}
