using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lavel : MonoBehaviour {
    public bool OnActived;
    public Vector3 ActivatedRotation;
	// Use this for initialization
	void Start () {
        OnActived = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (OnActived)
        {
            transform.eulerAngles = ActivatedRotation;
        }
	}

    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "PlayerTrigger")
        {
            if (Input.GetMouseButtonDown(0))
            {
                OnActived = true;

            }
        }
    }
}
