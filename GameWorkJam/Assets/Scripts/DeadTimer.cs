using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DeadTimer : MonoBehaviour {
    public static DeadTimer Instance;
    public float timer;
    public Text TimeText;
    [HideInInspector] public bool EndTime;
    // Use this for initialization
    private void Awake()
    {
        Instance = this;

    }
    void Start () {
        EndTime = false;
	}
	
	// Update is called once per frame
	void Update () {

        TimeText.text = ((int)(timer)).ToString();
        if (timer <= 0)
        {
            EndTime = true;
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
