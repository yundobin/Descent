using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Door_cube;
    int x;
    int z;
    bool MakeCube;
    void Start()
    {
        MakeCube = true;
        setXY();
    }
    void setXY()
    {
        x = Random.Range(-3, 3);
        z = Random.Range(-3, 3);
        if(x==z && x==0)
        {
            setXY();
        }
        else
        {
            Door();
        }
    }    

    void Door()
    {
        if (MakeCube == true)
        {
            this.gameObject.transform.position = new Vector3((float)2.5 * x, (float)0, (float)2.5 * z);
        }
        MakeCube = false;
    }
}