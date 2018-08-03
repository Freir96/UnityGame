using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkGUI : MonoBehaviour {
    bool isTalking;
    private DisplayManager displayManager;
    // Use this for initialization
    void Start () {
        isTalking = false;
        //var boxCollider = gameObject.AddComponent<BoxCollider>();
      //  boxCollider.isTrigger = true;
    }
	
	// Update is called once per frame
	void Update () {
       // Debug.Log("Hi");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (isTalking == false)
        {
			isTalking = true;
            displayManager.DisplayMessage("Hello Player!");
            Debug.Log("entered");
        }
    }
}
