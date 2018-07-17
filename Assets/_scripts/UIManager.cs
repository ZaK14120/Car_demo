using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class UIManager : MonoBehaviour {

    // Use this for initialization

    public List<Button> Buttons;
    public GameObject Car;
    public GameObject materialHolder;
    public GameObject wheelHolder;
    bool isSteering;
    bool isMaterialMenu;
    bool isWheelMenu;

    public static UIManager instance;

    void Awake()
    {
        instance = this;
    }

	void Start () {
        isSteering = false;
        isMaterialMenu = false;
        isWheelMenu = false;
        materialHolder.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        wheelHolder.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        Buttons[0].gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LaunchCar() {
        Car.SetActive(true);
        Buttons[0].gameObject.SetActive(false);
        Buttons[1].gameObject.SetActive(true);
        Buttons[2].gameObject.SetActive(true);
        Buttons[3].gameObject.SetActive(true);
    }

    public void SteeringPanel() {
        if (!isSteering)
        {
            Buttons[4].gameObject.SetActive(true);
            Buttons[5].gameObject.SetActive(true);
            isSteering = true;
        }
        else {
            Buttons[4].gameObject.SetActive(false);
            Buttons[5].gameObject.SetActive(false);
            isSteering = false;
        }
    }

    public void MaterialMenuToggle()
    {
        isMaterialMenu = !isMaterialMenu;
    }

    public void OpenMaterialHolder()
    {
        if (isMaterialMenu)
        {
            
            materialHolder.SetActive(true);
            materialHolder.transform.DOScale(new Vector3(1f, 1f, 1f), 0.5f).SetEase(Ease.Linear);
        }
        else
        {
            
            materialHolder.transform.DOScale(new Vector3(0.1f, 0.1f, 0.1f), 0.5f).SetEase(Ease.Linear).OnComplete(() =>
            {
                materialHolder.SetActive(false);
            });
        }
    }

    public void WheelMenuToggle()
    {
        isWheelMenu = !isWheelMenu;
    }

    public void OpenWheelHolder()
    {
        if (isWheelMenu)
        {

            wheelHolder.SetActive(true);
            wheelHolder.transform.DOScale(new Vector3(1f, 1f, 1f), 0.5f).SetEase(Ease.Linear);
        }
        else
        {

            wheelHolder.transform.DOScale(new Vector3(0.1f, 0.1f, 0.1f), 0.5f).SetEase(Ease.Linear).OnComplete(() =>
            {
                wheelHolder.SetActive(false);
            });
        }
    }
}
