using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public LightToggler other;
    public LogMonitor logg;
    
    void OnTriggerEnter(Collider col)
    {
        if (col.GetComponent<Rigidbody>().name == "battery") 
        {
            other.lightToggling();
        }
        
    }
}
