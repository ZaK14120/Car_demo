using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WheelRotate : MonoBehaviour {

    public GameObject[] Wheel;
    public bool isForce;
    // Use this for initialization

    public static WheelRotate instance;

    private void Awake()
    {
        instance = this;
        isForce = false;
    }
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        if (isForce)
            Acceleration();
        else
            Brakes();
	}

    public void Acceleration()
    {
        foreach (GameObject whee in Wheel)
        {
            whee.transform.DOLocalRotate(new Vector3(-360, 0, 0), 1f, RotateMode.FastBeyond360).SetRelative();
        }
    }

    public void Brakes() {
        foreach (GameObject whee in Wheel)
        {
            whee.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.2f, RotateMode.Fast);
        }
    }
}
