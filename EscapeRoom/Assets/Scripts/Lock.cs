using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;


public class Lock : MonoBehaviour {

    [SerializeField]
    private Door doorObj;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider collision)
    {
        print("collision");
        GameObject handParent= collision.gameObject.transform.parent.gameObject;
        handParent.GetComponent<Hand>().DetachObject(collision.gameObject);
        handParent.GetComponent<Hand>().HoverUnlock(null);
        handParent.transform.GetChild(1).gameObject.SetActive(true);

        if (collision.gameObject.GetComponent<Key>() != null)
        {
            print("collission with key");
            doorObj.locks--;
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        if(collision.gameObject.GetComponent<WrongKey>() != null)
        {
            Destroy(collision.gameObject);
        }
        
    }
}
