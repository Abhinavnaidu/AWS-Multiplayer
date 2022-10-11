using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargeMovement : MonoBehaviour
{
    [SerializeField]
    float speed = 2.5f;

    [SerializeField]
    float distance = 5f;
  
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * speed, distance ),transform.position.y , transform.position.z);
    }
}
