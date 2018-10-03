using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {
    [SerializeField]
    private GameObject[] collectables;
    [SerializeField]
    private GameObject destroyedBox;
    private float time ;
    private float timer;
    [SerializeField]
    private AudioClip destroy;
    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        time = 10;
        timer = 0;
        audioSource = GetComponent<AudioSource>();
	}

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= time)
        {
            setTime();
            insertCollectable();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "fire")
        {
            Destroy(other, 1);
            audioSource.PlayOneShot(destroy);
            GameObject des_boxInstance = Instantiate(destroyedBox, transform.position, Quaternion.identity);
            Destroy(des_boxInstance, 2f);
            

        }
    }
    void setTime()
    {
        time = Random.Range(1f, 9f);
        timer = 0;
    }
    void insertCollectable()
    {
        float speed = Random.Range(1f, 5f);
        float randomZ = Random.Range(-8f, 8f);
        float step = speed * Time.deltaTime;
        GameObject toBeSpawned = Instantiate(this.gameObject, new Vector3(-10, 0f, randomZ), Quaternion.identity);

    }
}
