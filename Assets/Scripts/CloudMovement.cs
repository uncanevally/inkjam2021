using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    public bool randomSpeed = false;
    public float speed;
    private float movingSpeed;
    private void Start()
    {
        if (randomSpeed == true)
        {
            movingSpeed = Random.Range(0.2f, 4f);
        }
        else
        {
            movingSpeed = speed;
        }
    }
    void Update()
    {
        transform.Translate(movingSpeed * Time.deltaTime, 0, 0);


        if (transform.position.x > 60)
        {
            Start();
            transform.position = new Vector3(-200, transform.position.y, transform.position.z);
            transform.rotation = new Quaternion();
        }
    }
}
