using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnMovement : MonoBehaviour
{
    public GameObject target;
    public float speed;
    private AudioSource audioSource;
    Spawns spawns ;
    // Use this for initialization
    void Start()
    {
        speed = 1f;
        spawns = GameObject.Find("GameController").GetComponent<Spawns>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       speed= spawns.speed;
        Debug.Log(speed);
        //  transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        transform.Translate(Vector3.back * speed * Time.deltaTime);
        if (transform.position.z <= target.transform.position.z -20)
        {
            Debug.Log("passed");
            Destroy(this.gameObject, 0f);



        }
    }
    void setSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}
