using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class AppManager : MonoBehaviour {
    
    public PlaneFinderBehaviour planeTracker;
    public GameObject AppUICanvas;

    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void StopScanning()
	{
        planeTracker.gameObject.SetActive(false);
        AppUICanvas.SetActive(true);
    }


	public void ResetAR()
	{

        Application.LoadLevel(0);
	}
}
