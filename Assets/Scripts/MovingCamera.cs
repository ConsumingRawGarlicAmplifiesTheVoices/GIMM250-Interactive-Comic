using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCamera : MonoBehaviour
{
    public Camera cam;
    public int lerpSpeed;

    private float cameraPositionX;
    private float cameraPositionY;
    private float cameraSize;
    private float defaultCameraSize;
    private Vector3 target;
    private Vector3 defaultPosition;

    public void Start()
    {
        target = cam.transform.position;
        cameraSize = cam.orthographicSize;
        defaultCameraSize= cam.orthographicSize;
        cameraPositionX = cam.transform.position.x;
        cameraPositionY = cam.transform.position.y;
        defaultPosition = cam.transform.position;
    }

    public void Update()
    {
        target = new Vector3(cameraPositionX, cameraPositionY, -10);
        Vector3 cameraPos = Vector3.Lerp(cam.transform.position, target, lerpSpeed * Time.deltaTime);
        cam.transform.position = cameraPos;
        cam.orthographicSize = (int)(100 * Mathf.Lerp(cam.orthographicSize, cameraSize, lerpSpeed * Time.deltaTime)) / 100f;
        if(Input.GetKey(KeyCode.Space))
        {
            cameraPositionX = defaultPosition.x;
            cameraPositionY = defaultPosition.y;
            cameraSize = defaultCameraSize;
        }
    }

    public void UpdateSize(float tempCameraSize)
    {
        cameraSize = tempCameraSize;
    }

    public void UpdateX(float tempCameraPositionX)
    {
        cameraPositionX = tempCameraPositionX;
    }

    public void UpdateY(float tempCameraPositionY)
    {
        cameraPositionY = tempCameraPositionY;
    }
}
