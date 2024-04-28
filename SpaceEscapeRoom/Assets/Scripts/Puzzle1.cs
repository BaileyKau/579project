using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puzzle1 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI current;
    [SerializeField] string correct;
    [SerializeField] string clue;
    [SerializeField] string def;

    int gameState;

    // Function to handle when button is pressed
    public void ButtonPressed(string number) 
    {
        // Only run if game is happening
        if (gameState == 0) 
        {
            // Check if text is still default
            if (current.text == def)
            {
                // If so, init
                current.text = "";
            }

            // Add current number
            current.text += number;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Set gameState to 0 to indicate game is happening
        gameState = 0;

        // Init current to default text
        current.text = def;
    }

    // Update is called once per frame
    void Update()
    {
        // Only run logic if game is happening
        if (gameState == 0) 
        {
            // Check if user is correct
            if (current.text == correct) 
            {
                // Set clue and end game
                current.text = "Clue: " + clue;
                gameState = 1;
            }

            // Check if user has entered too many numbers
            else if (current.text.Length >= correct.Length && (current.text != def))
            {
                // Init back to blank
                current.text = "";
            }

            // Do nothing
            else {}
        }

        // Game has ended
        else 
        {
            current.text = "Clue: " + clue;
        }
    }
}
