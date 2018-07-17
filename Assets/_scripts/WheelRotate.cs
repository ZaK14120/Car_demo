using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WheelRotate : MonoBehaviour {

    public GameObject[] Wheel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (CarMovement.instance.isForce)
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
