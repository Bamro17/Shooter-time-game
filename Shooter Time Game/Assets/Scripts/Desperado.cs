using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desperado : MonoBehaviour
{
    public GameObject player;
    public float radius = 10;
    float speed = 4;
    public float innerRadius = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 relativePosition = player.transform.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(relativePosition);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, 180.0f * Time.deltaTime);
    }
}
