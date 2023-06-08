using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ButtonZoom : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField]
    Camera cam;

    [SerializeField]
    float zoom_speed;

    [SerializeField]
    int direction;
    bool zoom = false;

    [SerializeField]
    int min_zoom, max_zoom;

    [SerializeField]
    TMP_Text zoom_text;

    void Start()
    {
        zoom_text.text = 175 - (int)(cam.fieldOfView * 2.5f) + "%";
    }

    void FixedUpdate()
    {
        if (zoom == false)
            return;

        cam.fieldOfView += zoom_speed * direction;

        if (cam.fieldOfView > max_zoom)
        {
            cam.fieldOfView = max_zoom;
        }
        if (cam.fieldOfView < min_zoom)
        {
            cam.fieldOfView = min_zoom;
        }

        zoom_text.text = 175 - (int)(cam.fieldOfView * 2.5f) + "%";
    }

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        zoom = true;
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        zoom = false;
    }
}
