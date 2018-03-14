using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Door : MonoBehaviour {
    private bool enabling = false;
    public int locks = 3;

	// Use this for initialization
	void Start () {
        /*GetComponent<Throwable>().enabled = false;
        GetComponent<Interactable>().enabled = false;
        GetComponent<VelocityEstimator>().enabled = false;

        print("throw: " + this.gameObject.GetComponent<Throwable>().enabled);
        print("interact: " + this.gameObject.GetComponent<Interactable>().enabled);
        print("vel: " + this.gameObject.GetComponent<VelocityEstimator>().enabled);*/
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!enabling)
        {

            if (locks == 0)
            {
                enabling = true;
                /*this.gameObject.GetComponent<Throwable>().enabled = true;
                this.gameObject.GetComponent<Interactable>().enabled = true;
                this.gameObject.GetComponent<VelocityEstimator>().enabled = true;*/

                gameObject.AddComponent<Throwable>();
                gameObject.AddComponent<Interactable>();
                gameObject.AddComponent<VelocityEstimator>();
            }
        }
	}
}
