using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject LeftArm;
    public GameObject RightArm;
    public GameObject Weapon;

    public float speed;
    Vector3 lookDirection;
    private void Awake()
    {
        GameObject.Find("Floor").GetComponent<Floor>();
        Floor.Door = false;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) ||
           Input.GetKey(KeyCode.RightArrow) ||
           Input.GetKey(KeyCode.DownArrow) ||
           Input.GetKey(KeyCode.UpArrow))
        {
            float xx = Input.GetAxisRaw("Vertical");
            float zz = Input.GetAxisRaw("Horizontal");
            lookDirection = xx * Vector3.forward + zz * Vector3.right;

            transform.rotation = Quaternion.LookRotation(lookDirection);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Invoke("Up", 0.01f);
            Invoke("Down", 0.25f);
        }
    }
    void Up()
    {
        LeftArm.transform.Rotate(new Vector3(30, 0, 0));
        RightArm.transform.Rotate(new Vector3(0, 0, 30));
        Weapon.transform.Rotate(new Vector3(30, 0, 0));
    }


    void Down()
    {
        LeftArm.transform.Rotate(new Vector3(-30, 0, 0));
        RightArm.transform.Rotate(new Vector3(0, 0, -30));
        Weapon.transform.Rotate(new Vector3(-30, 0, 0));
    }
}