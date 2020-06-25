using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooterScript : MonoBehaviour
{
    public GameObject bullet;
    public float timebetweenshots = 1;
    bool canShoot = true;
    float timeUntilNextShot = 1;
    public PlayerController pc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeUntilNextShot)
        {
            canShoot = true;
        }
        if (Input.GetMouseButtonDown(0) && canShoot && pc.isDead == false)
        {
            Instantiate(bullet, this.transform.position, this.transform.rotation);
            canShoot = false;
            timeUntilNextShot = Time.time + timebetweenshots;
        }
    }
}
