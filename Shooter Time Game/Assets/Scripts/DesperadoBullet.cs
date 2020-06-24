using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesperadoBullet : MonoBehaviour
{
    public float speed = 4;
    float lifetime = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
