using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSize : MonoBehaviour
{
    Camera mainCamera;
    float timeElapsed;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        mainCamera.orthographicSize = Mathf.Abs(Mathf.Sin(timeElapsed) * 10f);
    }
}
