using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timer;
    [SerializeField] float time;

    [SerializeField] string correctPassword;
    [SerializeField] TextMeshProUGUI currentPassword;

    int gameState;

    // Function to handle when numberpad button is pressed
    public void ButtonPressed(string number) 
    {
        if (currentPassword.text.Length <= correctPassword.Length)
        {
            // Add the current number to the current password
            currentPassword.text += number;
        }
    }

    // Start is called before the first frame update
    void Start() 
    {
        // Start time
        time = 300;

        // Init current password
        currentPassword.text = "";

        // Init game state to 0 (being played)
        gameState = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Only when game is running
        if (gameState == 0) 
        {
            // Check if time is greater than 0
            if (time > 0) 
            {
                // If so, subtract elapsed time
                time -= Time.deltaTime;
            }

            // Otherwise, set time to 0
            else 
            {
                time = 0;

                // Set gameState to -1 to indicate loss
                gameState = -1;
            }

            // Calculate the minutes and seconds
            int min = Mathf.FloorToInt(time / 60);
            int sec = Mathf.FloorToInt(time % 60);

            // Format text accordingly
            timer.text = string.Format("{0:00}:{1:00}", min, sec);

            // Check if the current password entered is 
            if (currentPassword.text == correctPassword) 
            {
                // Set to 1 to indicate win and change text
                gameState = 1;
                timer.text = "WIN";
            }

            // Check if password length is greater than correct
            else if (currentPassword.text.Length >= correctPassword.Length) 
            {
                // If so, init
                currentPassword.text = "";
            }

            // Else, do nothing
            else {}
        }

        // Game has lost
        else if (gameState == -1) 
        {
            timer.text = "Loss";
            currentPassword.text = "Loss";
        }

        // Game has won
        else {}
    }
}
