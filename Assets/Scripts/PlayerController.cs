using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Min(1f)]
    [SerializeField] float speed = 6f;

    Vector3 moveDir;
    Vector3 targetPosition;

    [SerializeField]
    [Tooltip("Minimum distance to target before allowing another input to be processed.")]
    [Range(0f, 0.999f)]
    float minInputDistance = 0f;

    [SerializeField]
    [Tooltip("Auto calculates Min Input Distance based on speed * deltaTime.")]
    bool autoDistance = true;

    void Start()
    {
        targetPosition = transform.position;
    }

    void Update()
    {
        if (autoDistance)
            minInputDistance = speed * Time.deltaTime;

        if (Vector3.Distance(transform.position, targetPosition) <= minInputDistance)
        {
            moveDir = Vector3.zero;

            if (Input.GetKey(KeyCode.W))
                moveDir.y = 1;
            else if (Input.GetKey(KeyCode.D))
                moveDir.x = 1;
            else if (Input.GetKey(KeyCode.S))
                moveDir.y = -1;
            else if (Input.GetKey(KeyCode.A))
                moveDir.x = -1;

            targetPosition += moveDir;
        }
        
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }
}
