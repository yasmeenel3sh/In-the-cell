using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float health;
    [SerializeField]
    private AudioClip[] sounds;
    private float counter;
    private AudioSource audioSource;
    // Use this for initialization
    void Start()
    {
        health = 100f;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        if (counter == 100)
        {
            health--;
            counter = 0;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided");
        if (other.tag == "cake")
        {
            if (health < 200)
            {
                health += 10f;
                if (health > 200)
                    health = 200;
            }
            this.audioSource.PlayOneShot(sounds[0]);
        }
        else
        if (other.tag == "butter")
        {
            this.audioSource.PlayOneShot(sounds[1]);
            if (health < 200)
            {
                health += 10f;
                if (health > 200)
                    health = 200;
            }

        }
        else
        if (other.tag == "fruit")
        {
            if (health < 100)
            {
                health += 0.5f;
                ;
            }
            this.audioSource.PlayOneShot(sounds[2]);
        }
        else
        if (other.tag == "meat")
        {
            if (health < 100)
            {
                health += 0.5f;
            }
            this.audioSource.PlayOneShot(sounds[3]);
        }
        else
        if (other.tag == "insulin")
        {
            if (health > 100)
            {
                health -= 2f;
                if (health < 100)
                    health = 100;
            }
            this.audioSource.PlayOneShot(sounds[4]);
        }
        else
            if (other.tag == "lipase")
        {
            if (health > 100)
            {
                health -= 2f;
                if (health < 100)
                    health = 100;
            }
            this.audioSource.PlayOneShot(sounds[5]);
        }
        else if (other.tag == "slowDown")
        {

        }

        Destroy(other.gameObject, 1.5f);
    }
}
