using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timer;
    [SerializeField] float time;

    void Start() 
    {
        // Start time
        time = 10;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if time is greater than 0
        if (time > 0) {
            // If so, subtract elapsed time
            time -= Time.deltaTime;
        }

        // Otherwise, set time to 0
        else {
            time = 0;
        }

        // Calculate the minutes and seconds
        int min = Mathf.FloorToInt(time / 60);
        int sec = Mathf.FloorToInt(time % 60);

        // Format text accordingly
        timer.text = string.Format("{0:00}:{1:00}", min, sec);
    }
}
