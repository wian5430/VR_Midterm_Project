// Copyright 2016/2017 By Hedgehog Team / Creepy Cat / Barking Dog
using UnityEngine;
using System.Collections;

public class HoriDoorManager : MonoBehaviour {

	public DoorHori door1;
	public DoorHori door2;

	public void Opener(){
		if (door1!=null){
			door1.OpenDoor();	
		}

		if (door2!=null){
			door2.OpenDoor();	
		}

	}
}
