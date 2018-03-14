using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        print("collision");
        if (collision.gameObject.GetComponent<Key>() != null)
        {
            print("collission with key");
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
