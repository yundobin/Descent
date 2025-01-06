using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public GameObject StartBtn;
    public string sceneName;
    void Start()
    {
        StartBtn.SetActive(true);
    }

    // Update is called once per frame
    public void start()
    {
        SceneManager.LoadScene(sceneName);
    }
    void Update()
    {

    }
}
