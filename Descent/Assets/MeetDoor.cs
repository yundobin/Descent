using UnityEngine;

public class MeetDoor : MonoBehaviour
{
    
    void Start()
    {
        GameObject.Find("Floor").GetComponent<Floor>();
    }
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Door"))
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
            Floor.Door = true;
            }
        }
    }
}
