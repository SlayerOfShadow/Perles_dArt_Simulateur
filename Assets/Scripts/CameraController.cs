using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    Animator model_animator;

    [SerializeField]
    List<Transform> camera_positions, camera_sitting_positions;

    [SerializeField]
    private float duration;

    Coroutine camera_move_coroutine;

    public void move_camera(int position)
    {
        if (camera_move_coroutine != null)
        {
            StopCoroutine(camera_move_coroutine);
        }

        camera_move_coroutine = StartCoroutine(move_camera_coroutine(position));
    }

    private IEnumerator move_camera_coroutine(int position)
    {
        Transform target_position;
        if (model_animator.GetBool("Sitting"))
        {
            target_position = camera_sitting_positions[position];
        } else
        {
            target_position = camera_positions[position];
        }
        Quaternion target_rotation = target_position.rotation;
        Vector3 start_position = transform.position;
        Quaternion start_rotation = transform.rotation;
        float elapsed_time = 0f;

        while (elapsed_time < duration)
        {
            float t = elapsed_time / duration;
            transform.position = Vector3.Lerp(start_position, target_position.position, t);
            transform.rotation = Quaternion.Slerp(start_rotation, target_rotation, t);
            elapsed_time += Time.deltaTime;
            yield return null;
        }

        transform.position = target_position.position;
        transform.rotation = target_rotation;
    }
}
