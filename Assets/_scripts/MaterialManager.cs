using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialManager : MonoBehaviour {

    RaycastHit hit;
    public List<Material> carMaterial;
    public List<Material> wheelMaterial;
    public GameObject carBody;
    public GameObject[] wheels;
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            ChangeMaterial();
        }
	}

    public void ChangeMaterial()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);        
        if(Physics.Raycast(ray, out hit,1000f))
        {
            if (hit.collider.tag == "Red_material")
            {

                carBody.GetComponent<MeshRenderer>().material = carMaterial[0];
            }
            else if(hit.collider.tag == "Yellow_material")
            {
                carBody.GetComponent<MeshRenderer>().material = carMaterial[1];
            }
            else if (hit.collider.tag == "Blue_material")
            {
                carBody.GetComponent<MeshRenderer>().material = carMaterial[2];
            }
            else if (hit.collider.tag == "Gray_wheel")
            {
                foreach (GameObject wheel in wheels)
                {
                    wheel.GetComponent<MeshRenderer>().material = wheelMaterial[0];
                }
            }
            else if (hit.collider.tag == "Gold_wheel")
            {
                foreach (GameObject wheel in wheels)
                {
                    wheel.GetComponent<MeshRenderer>().material = wheelMaterial[1];
                }
            }
            else if (hit.collider.tag == "Black_wheel")
            {
                foreach (GameObject wheel in wheels)
                {
                    wheel.GetComponent<MeshRenderer>().material = wheelMaterial[2];
                }
            }
        }
    }

}
