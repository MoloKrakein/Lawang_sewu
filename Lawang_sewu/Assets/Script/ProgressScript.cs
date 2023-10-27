using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressScript : MonoBehaviour
{
    public Slider slider;
    public int maxTimerinSeconds = 60;
    private float timeElapsed = 0f;

    private void Start()
    {
        slider.maxValue = maxTimerinSeconds;
    }

    private void Update()
    {
        // timer countdown
        timeElapsed += Time.deltaTime;

        if (timeElapsed <= maxTimerinSeconds)
        {
            slider.value = timeElapsed;
        }
        else
        {
            slider.value = maxTimerinSeconds;
        }
    }
}
