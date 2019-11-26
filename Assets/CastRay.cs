using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastRay : MonoBehaviour
{
    public GameObject parent;
    public GameObject obj;
    public LogMonitor logger;
    
    private int targetLayer = 1 << 8; // Layer 8 (targets)
    private int teleLayer = 1 << 9;
   

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //logger.ButtonDebugger();
            // The Unity raycast hit object, which will store the output of our raycast
            RaycastHit hit;
            // Does the ray intersect any objects excluding the player layer
            // Parameters: position to start the ray, direction to project the ray, output for raycast, limit of ray length, and layer mask
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, targetLayer))
            {
                // The object we hit will be in the collider property of our hit object.
                // We can get the name of that object by accessing it's Game Object then the name property

                logger.DestroyNot();
            }
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, teleLayer))
            {
                // The object we hit will be in the collider property of our hit object.
                // We can get the name of that object by accessing it's Game Object then the name property
                parent.transform.position = new Vector3(hit.point.x, 0, hit.point.z);
            }
            
        }
        if (Input.GetButtonDown("Fire2"))
        {
            logger.DebugButton();
        }
    }
}