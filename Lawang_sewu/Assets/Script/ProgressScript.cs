using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressScript : MonoBehaviour
{
  public Slider slider;
  public int maxTimerinSeconds = 60;
  private int secondsLeft;

    private void Start() {
        slider.maxValue = maxTimerinSeconds;
    }

    public void SetProgress(int seconds){
        slider.value = seconds;
    }

    private void Update() {
        // timer countdown

        secondsLeft = maxTimerinSeconds - (int)Time.timeSinceLevelLoad;
        SetProgress(secondsLeft);
    }
   
}
