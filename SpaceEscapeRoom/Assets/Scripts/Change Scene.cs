using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Function to move player to main scene
    public void changeScene() 
    {
        // Teleport player
        SceneManager.LoadScene("Main Scene", LoadSceneMode.Additive);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
