using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timer;
    [SerializeField] float time;

    string correctPassword;
    [SerializeField] TextMeshProUGUI currentPassword;

    // Function to handle when numberpad button is pressed
    public void ButtonPressed(string number) 
    {
        // Add the current number to the current password
        currentPassword.text += number;
    }

    void Start() 
    {
        // Start time
        time = 10;

        // Init correct password and current password
        correctPassword = "4739";
        currentPassword.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        // Check if time is greater than 0
        if (time > 0) 
        {
            // If so, subtract elapsed time
            time -= Time.deltaTime;
        }

        // Player has won
        else if (time == -1) 
        {
            // Win
        }

        // Otherwise, set time to 0
        else 
        {
            time = 0;
        }

        // Calculate the minutes and seconds
        int min = Mathf.FloorToInt(time / 60);
        int sec = Mathf.FloorToInt(time % 60);

        // Format text accordingly
        timer.text = string.Format("{0:00}:{1:00}", min, sec);

        // Check if the current password entered is 
        if (currentPassword.text == correctPassword) 
        {
            // Set to -1 to indicate win
            time = -1;
        }

        // Check if user has entered password too long
        else if (currentPassword.text.Length > correctPassword.Length)
        {
            // If so, reset
            currentPassword.text = "";
        }
    }
}
