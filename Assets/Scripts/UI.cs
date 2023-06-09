using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UI : MonoBehaviour
{
    [SerializeField]
    GameObject model;
    Renderer model_renderer;

    [SerializeField]
    List<GameObject> panels, sub_panels;

    [SerializeField]
    List<Outline> color_buttons_outlines, jewels_buttons_outlines;

    [SerializeField]
    List<GameObject> panel_arrows;

    void Start()
    {
        model_renderer = model.GetComponent<Renderer>();
    }

    public void change_model_material(Material material)
    {
        if (model_renderer.material.color != material.color)
        {
            model_renderer.material = material;
            foreach (Outline outline in color_buttons_outlines)
            {
                outline.enabled = false;
            }
            EventSystem.current.currentSelectedGameObject.GetComponent<Outline>().enabled = true;
        }
    }

    public void toggle_panel(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
    }

    public void set_active_panel(GameObject panel)
    {
        toggle_panel(panel);
        foreach (GameObject p in panel_arrows)
        {
            p.SetActive(false);
        }
        switch(panel.name)
        {
            case "Panel couleurs":
                panel_arrows[0].SetActive(panel.activeSelf);
                break;
            case "Panel bijoux":
                panel_arrows[1].SetActive(panel.activeSelf);
                break;
            case "Panel poses":
                panel_arrows[2].SetActive(panel.activeSelf);
                break;
        }
        foreach (GameObject p in panels)
        {
            if (p != panel) p.SetActive(false);
        }
        foreach (GameObject p in sub_panels)
        {
            p.SetActive(false);
        }
        foreach (Outline o in jewels_buttons_outlines)
        {
            o.enabled = false;
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
