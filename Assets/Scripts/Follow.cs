using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] Vector3 offset;

    void Start()
    {
            
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!target)
        {
            Debug.Log($"Follow script is applyed to {ToString()} but it has no target assigned.");
            return;
        }

        transform.position = target.transform.position + offset;
    }
}
