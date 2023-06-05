using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonRotate : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField]
    GameObject model;

    [SerializeField]
    float rotation_speed;

    [SerializeField]
    int direction;
    bool rotate = false;

    void FixedUpdate()
    {
        if (rotate == false)
            return;

        model.transform.Rotate(Vector3.up * rotation_speed * direction * Time.deltaTime);
    }

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        rotate = true;
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        rotate = false;
    }
}
