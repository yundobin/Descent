using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Floor : MonoBehaviour
{
    //public string SceneName;
    public static bool Door;
    public int floor;
    public TextMeshProUGUI FloorText;


    void Awake()
    {
        Door = false;
        floor = 1;
       
    }

    void Update()
    {
        FloorText.text = "Floor : " + floor.ToString();
        if (Door == true)
        {
            floor++;
            SceneManager.LoadScene("Scene1");
            Door = false;
        } 
    }
}
