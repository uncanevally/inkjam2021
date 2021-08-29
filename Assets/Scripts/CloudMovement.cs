using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{

    public float speed = 0.2f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);

        if (transform.position.x > 60)
        {
            transform.position = new Vector3(-200, transform.position.y, transform.position.z);
        }
    }
}
