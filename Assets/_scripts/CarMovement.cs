using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour {

	// Use this for initialization

	Rigidbody rb;
    public bool isMoving;
   

    public static CarMovement instance;

    void Awake() {
        
        instance = this;
    }

	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (isMoving)
            MoveCar();
	}

    public void MoveCar()
    {
        rb.AddForce(new Vector3(-1f, 0f, 0f), ForceMode.Acceleration);
        WheelRotate.instance.isForce = true;
	}

    public void MoveToggle() {
        isMoving = true;
    }

    public void StopCar()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        isMoving = false;
        WheelRotate.instance.isForce = false;
    }

    public void ToggleOff()
    {
        isMoving = false;
    }
}
