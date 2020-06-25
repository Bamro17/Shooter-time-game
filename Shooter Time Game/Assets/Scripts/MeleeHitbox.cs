using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeHitbox : MonoBehaviour
{
    public Cavemen cm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("player"))
        {
            cm.swordS.SetActive(false);
            cm.swordA.SetActive(true);
            cm.pauser = true;
        }
    }
}
