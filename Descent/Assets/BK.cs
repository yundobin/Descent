using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BK : MonoBehaviour
{
    public GameObject particle1;
    public bool isColliding = false;
    void Start()
    {
        
    }

    void Update()
    {
        if (isColliding && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(particle1, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("weapontouch"))
        {
            isColliding = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("weapontouch"))
        {
            isColliding = false;
        }
    }
}
