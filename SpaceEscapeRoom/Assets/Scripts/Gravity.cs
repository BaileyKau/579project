using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{

    [SerializeField] float thrust;
    [SerializeField] Rigidbody obj1;

    public void ButtonPressed() 
    {
        obj1.AddForce(transform.up * thrust);
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
