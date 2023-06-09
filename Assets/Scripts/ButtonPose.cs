using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPose : MonoBehaviour
{
    [SerializeField]
    GameObject model, stool;
    Animator model_animator;

    [SerializeField]
    CameraController cam;

    void Start()
    {
        model_animator = model.GetComponent<Animator>();
    }

    public void set_animation_bool(string name)
    {
        foreach (AnimatorControllerParameter p in model_animator.parameters)
        {
            model_animator.SetBool(p.name, false);
        }

        model_animator.SetBool(name, true);
        if (name == "Sitting")
        {
            stool.SetActive(true);
        } else
        {
            stool.SetActive(false);
        }
        cam.move_camera(0);
    }
}
