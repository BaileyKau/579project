using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class VentState : MonoBehaviour
{
    [SerializeField] Collider openCollider;
    [SerializeField] bool isOpen;

    void OnCollisionEnter(Collision col) {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (col.collider == openCollider)
        {
            isOpen = true;
            m_onVentOpen.Invoke();
        }
    }

    void OnCollisionExit(Collision col) {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (col.collider == openCollider)
        {
            isOpen = false;
            m_onVentClose.Invoke();
        }
    }

    [SerializeField]
    [Tooltip("Events to trigger when the vent opens")]
    UnityEvent m_onVentOpen = new UnityEvent();

    [SerializeField]
    [Tooltip("Events to trigger when the vent closes")]
    UnityEvent m_onVentClose = new UnityEvent();

    public UnityEvent onVentOpen => m_onVentOpen;
    public UnityEvent onVentClose => m_onVentClose;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}
