using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RotateLeft_Menu : MonoBehaviour, IInputClickHandler, IInputHandler
{
    public GameObject parentHologram;
    private bool isActive = false;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        //isActive = true;
        parentHologram.transform.Rotate(0, 3, 0);
        throw new NotImplementedException();
    }

    public void OnInputDown(InputEventData eventData)
    {
        isActive = true;
        parentHologram.transform.Rotate(0, 1, 0);
        throw new NotImplementedException();
    }

    public void OnInputUp(InputEventData eventData)
    {
        isActive = false;
        throw new NotImplementedException();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (isActive)
            parentHologram.transform.Rotate(0, 1, 0);
	}
}
