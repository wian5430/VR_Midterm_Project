using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public bool canHold = false;
    public bool holdin = false;
    public GameObject obj;
    public Transform guide;
    public LogMonitor logg;

    void Update()
    {

        if (Input.GetButtonDown("Jump"))
        {
            
            if (holdin == true)
            {
                throw_drop();
            }
            else if (canHold == true && holdin == false)
            {
                Pickup();
            }



        }//mause If

        //if (!canHold && obj)
        //    obj.transform.position = guide.position;

    }//update

    void OnTriggerEnter(Collider col)
    {
        if (col.GetComponent<Rigidbody>().name == "battery")
        {
            obj = col.gameObject;
            canHold = true;
            Debug.Log("can pickup battery");

        }
    }

    //We can use trigger or Collision
    void OnTriggerExit(Collider col)
    {
        canHold = false;
    }


    public void Pickup()
    {

        //We set the object parent to our guide empty object.
        obj.transform.SetParent(guide);


        //Set gravity to false while holding it
        obj.GetComponent<Rigidbody>().useGravity = false;
        obj.GetComponent<Rigidbody>().isKinematic = true;

        //we apply the same rotation our main object (Camera) has.
        //obj.transform.localRotation = transform.rotation;
        //We re-position the ball on our guide object 
        //obj.transform.position = guide.position;
        holdin = true;
        //canHold = false;
    }

    public void throw_drop()
    {

        //Set our Gravity to true again.
        obj.GetComponent<Rigidbody>().useGravity = true;
        obj.GetComponent<Rigidbody>().isKinematic = false;

        // we don't have anything to do with our ball field anymore
        obj.transform.parent = null;
        //obj = null;
        //Apply velocity on throwing
        //guide.GetChild(0).gameObject.GetComponent<Rigidbody>().velocity = transform.forward;

        //Unparent our ball
        //guide.GetChild(0).parent = null;
        //canHold = true;
        holdin = false;
    }
}

