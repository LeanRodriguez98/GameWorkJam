using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEntity : MonoBehaviour {
    public Lavel LavelKill;
    public Lavel AllLavelkill;
    public GameObject DieParticles;

	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        if (LavelKill.OnActived || AllLavelkill.OnActived)
        {
            Instantiate(DieParticles, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
	}
}
