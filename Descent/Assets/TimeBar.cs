using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeBar : MonoBehaviour
{
    public Image timeBar;

    public float time;

    void Start()
    {
        time = 60.0f;
    }

    void Update()
    {
        time -= Time.deltaTime;
        timeBar.fillAmount = (float)time / 60;
        if (time >= 60) time = 60;
        if (time <= 0) time = 0;
    }
}
