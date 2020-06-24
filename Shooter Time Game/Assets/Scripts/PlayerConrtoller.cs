using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConrtoller : MonoBehaviour
{
    public int speed = 5;
    public int rotateSpeed = 30;
    Rigidbody rb;
    public float jumpForce = 8.0f;
    bool jumping = false;
    public float healthCounter = 10;
    public bool isDead = false;
    public GameObject backupCamera;
    public GameObject mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (healthCounter == 0)
        {
            isDead = true;
            backupCamera.SetActive(true);
            mainCamera.SetActive(false);
            Destroy(this.gameObject);
        }
        else if (healthCounter > 0)
        {
            // Basic Movement code
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.back * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.Q))
            {
                transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.E))
            {
                transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
            }
            if (Input.GetButtonDown("Jump") && jumping == false)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                jumping = true;
            }
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            jumping = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            healthCounter--;
        }
    }
}
