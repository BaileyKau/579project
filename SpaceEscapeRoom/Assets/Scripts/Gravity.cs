using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{

    [SerializeField] float thrust;
    [SerializeField] Rigidbody player;

    bool toggle;

    // Function to handle button press
    public void ButtonPressed() 
    {
        // Check if toggle is false (gravity on)
        if (toggle == false) 
        {
            player.AddForce(transform.up * thrust);
            player.useGravity = false;
        }

        else
        {
            player.useGravity = true;
        }

        // Flip toggle
        toggle = !toggle;
    }

    // Start is called before the first frame update
    void Start()
    {
        toggle = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
