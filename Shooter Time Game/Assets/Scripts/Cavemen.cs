using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cavemen : MonoBehaviour
{
    public GameObject player;
    float speed = 4;
    public float radius = 10;
    public GameObject swordS;
    public GameObject swordA;
    public PlayerConrtoller pc;
    public bool pauser = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        
        if (Vector3.Distance(transform.position, player.transform.position) <= radius)
        {
            transform.LookAt(player.transform);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

        }
        Debug.Log("before thing");
        if (pauser == true)
        {
            swordA.SetActive(false);
            swordS.SetActive(true);
            Debug.Log("thing played");
            pauser = false;
        }
    }
    
}
