﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desperado2 : MonoBehaviour
{
    public GameObject player;
    float speed = 4;
    public float radius = 10;
    public float innerRadius = 8;
    private float shotTimer = 0.0f;
    public GameObject enemyBullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);

        shotTimer += Time.deltaTime;
        if (shotTimer > 1)
        {
            Instantiate(enemyBullet, this.transform.position, this.transform.rotation);
            shotTimer = 0;
        }

        Debug.Log(Vector3.Distance(transform.position, player.transform.position) >= radius);
        if (Vector3.Distance(transform.position, player.transform.position) >= radius)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            Debug.Log("Move to");
            
        }
        
        else if (Vector3.Distance(transform.position, player.transform.position) <= innerRadius)
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
            Debug.Log("Move away");
        }
        
    }
}