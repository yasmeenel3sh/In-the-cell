using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public BarScript bar;

    private float health;
	// Use this for initialization
	void Start () {
        health = 100f;
	}
	
	// Update is called once per frame
	void Update () {
		UpdateHealthBar();
	}

	void UpdateHealthBar() {
		if (Input.GetKeyDown(KeyCode.Q)) {
			bar.fillAmount -= 0.1;
		}
		if(Input.GetKeyDown(KeyCode.W)) {
			bar.fillAmount += 0.1;
		}
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
