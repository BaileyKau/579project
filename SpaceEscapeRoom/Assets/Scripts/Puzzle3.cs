using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class Puzzle3 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI screen;
    [SerializeField] string correct;
    [SerializeField] string clue;
    [SerializeField] string def;
    
    List<char> current;

    int gameState;

    // Function to handle when button is pressed
    public void VentOpened(string number) 
    {
        // Only run if game is happening
        if (gameState == 0) 
        {
            // Get char from string
            char numChar = number.ToCharArray()[0];

            // Add number to list
            current.Add(numChar);
        }
    }

    // Function to handle when button is pressed
    public void VentClosed(string number) 
    {
        // Only run if game is happening
        if (gameState == 0) 
        {
            // Get char from string
            char numChar = number.ToCharArray()[0];

            // Remove number from list (iterate using removeAll)
            current.RemoveAll((c) => c == numChar);
        }
    }

    // Function to check if answer is equal to list (without caring about order)
    bool equal(string ans, List<char> list)
    {
        // Convert params to char arrays
        List<char> list2 = new List<char>(ans.ToCharArray());

        // Check if lengths are equal
        if (list.Count != list2.Count)
        {
            // If not, return false
            return false;
        }

        // Sort each list
        list.Sort();
        list2.Sort();

        // Return if list is sequence equal to list2
        return list.SequenceEqual(list2);
    }

    // Start is called before the first frame update
    void Start()
    {
        // Set gameState to 0 to indicate game is happening
        gameState = 0;

        // Init list of current
        current = new List<char>();

        // Init screen text to default text
        screen.text = def;
    }

    // Update is called once per frame
    void Update()
    {
        // Only run logic if game is happening
        if (gameState == 0) 
        {
            // Check if equal
            if (equal(correct, current)) 
            {
                // If so, change gameState
                gameState = 1;
            }

            // Do nothing
            else {}
        }

        // Game has ended
        else 
        {
            screen.text = "Clue: " + clue;
        }
    }
}
