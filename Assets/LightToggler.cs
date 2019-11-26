using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightToggler : MonoBehaviour
{
    public HoriDoorManager other;
    public bool on = false;
    public GameObject lightSwitch;

    
    public void lightToggling()
    {
        if (on == false)
        {
            lightSwitch.SetActive(true);
            other.Opener();
            on = true;
        }
        else if (on == true)
        {
            lightSwitch.SetActive(false);
            on = false;
        }
    }
}
