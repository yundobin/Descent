using UnityEngine;

public class Dontdestroy : MonoBehaviour
{
    private static Dontdestroy instance = null;
    void Awake()
    {
        if(instance)
        {
            DestroyImmediate(this.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        
    }
}
