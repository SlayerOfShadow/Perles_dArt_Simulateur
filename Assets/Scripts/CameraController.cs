using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform[] cameraPositions;

    [SerializeField]
    private float duration;

    private Coroutine cameraMoveCoroutine;

    public void MoveCamera(int position)
    {
        if (cameraMoveCoroutine != null)
        {
            StopCoroutine(cameraMoveCoroutine);
        }

        cameraMoveCoroutine = StartCoroutine(MoveCameraCoroutine(position));
    }

    private IEnumerator MoveCameraCoroutine(int position)
    {
        Transform targetPosition = cameraPositions[position];
        Vector3 startPosition = transform.position;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition.position, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPosition.position;
    }
}
