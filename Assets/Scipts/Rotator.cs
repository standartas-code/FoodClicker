using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 70;

    public bool randomRotation = true;
    public Vector3 rotation;

    void Start()
    {
        if(randomRotation)
        {
            rotation = new Vector3();
            rotation.x = Random.Range(-1f, 1f);
            rotation.y = Random.Range(-1f, 1f);
            rotation.z = Random.Range(-1f, 1f);
        }
        
    }

    void Update()
    {
        transform.Rotate(rotation * speed * Time.deltaTime);
    }
}
