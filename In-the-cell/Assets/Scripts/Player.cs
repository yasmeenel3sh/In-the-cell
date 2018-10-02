using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private float health;
	// Use this for initialization
	void Start () {
        health = 100f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided");
        if (other.tag == "cake")
        {

        }else
        if(other.tag == "butter")
        {

        }else
        if (other.tag == "fruit")
        {

        }else
        if (other.tag == "meat")
        {

        }else
        if(other.tag == "insulin")
        {
            
        }
    }
}
