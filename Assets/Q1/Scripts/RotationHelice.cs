using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationHelice : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
	}
     public void TournerHelice(float vitesse)
    {
        transform.Rotate(0,0,vitesse);
        
    }
}
