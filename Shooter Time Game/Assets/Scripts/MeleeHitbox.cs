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
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            cm.swordS.gameObject.SetActive(false);
            cm.swordA.gameObject.SetActive(true);
            cm.pauser = 1;
            Debug.Log(cm.pauser);
        }
    }
}
