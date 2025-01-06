using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EC2 : MonoBehaviour
{
    public GameObject EventCube2_cube;
    public TimeBar timeBar;
    public bool isColliding = false;
    void Start()
    {
        this.gameObject.SetActive(true);
        timeBar = FindObjectOfType<TimeBar>();
        EventCube2();
    }
    void Update()
    {
        if (isColliding && Input.GetKeyDown(KeyCode.Space))
        {
            timeBar.time += 2;
            this.gameObject.SetActive(false);
        }
    }
    void EventCube2()
    {
        float RamdomSp = (int)Random.Range(1.0f, 21.0f);

        switch (RamdomSp)
        {
            case 1:
                EventCube2_cube.transform.position = new Vector3(-7.5f, 1.0f, 7.5f);
                break;
            case 2:
                EventCube2_cube.transform.position = new Vector3(-5.0f, 1.0f, 7.5f);
                break;
            case 3:
                EventCube2_cube.transform.position = new Vector3(-2.5f, 1.0f, 7.5f);
                break;
            case 4:
                EventCube2_cube.transform.position = new Vector3(0, 1.0f, 7.5f);
                break;
            case 5:
                EventCube2_cube.transform.position = new Vector3(2.5f, 1.0f, 7.5f);
                break;
            case 6:
                EventCube2_cube.transform.position = new Vector3(5.0f, 1.0f, 7.5f);
                break;
            case 7:
                EventCube2_cube.transform.position = new Vector3(7.5f, 1.0f, 7.5f);
                break;
            case 8:
                EventCube2_cube.transform.position = new Vector3(-7.5f, 1.0f, 5f);
                break;
            case 9:
                EventCube2_cube.transform.position = new Vector3(-5.0f, 1.0f, 5f);
                break;
            case 10:
                EventCube2_cube.transform.position = new Vector3(-2.5f, 1.0f, 5f);
                break;
            case 11:
                EventCube2_cube.transform.position = new Vector3(0f, 1.0f, 5f);
                break;
            case 12:
                EventCube2_cube.transform.position = new Vector3(2.5f, 1.0f, 5f);
                break;
            case 13:
                EventCube2_cube.transform.position = new Vector3(5.0f, 1.0f, 5f);
                break;
            case 14:
                EventCube2_cube.transform.position = new Vector3(7.5f, 1.0f, 5f);
                break;
            case 15:
                EventCube2_cube.transform.position = new Vector3(-7.5f, 1.0f, 2.5f);
                break;
            case 16:
                EventCube2_cube.transform.position = new Vector3(-5.0f, 1.0f, 2.5f);
                break;
            case 17:
                EventCube2_cube.transform.position = new Vector3(0f, 1.0f, 2.5f);
                break;
            case 18:
                EventCube2_cube.transform.position = new Vector3(2.5f, 1.0f, 2.5f);
                break;
            case 19:
                EventCube2_cube.transform.position = new Vector3(5.0f, 1.0f, 2.5f);
                break;
            case 20:
                EventCube2_cube.transform.position = new Vector3(7.5f, 1.0f, 2.5f);
                break;
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
