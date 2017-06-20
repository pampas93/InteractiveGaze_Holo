using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class ObjectManager : MonoBehaviour, IInputClickHandler, IInputHandler {

    Renderer com;
    

    public void OnInputClicked(InputClickedEventData eventData)
    {
        com.material.color = Color.white;
        throw new NotImplementedException();
    }

    public void OnInputDown(InputEventData eventData)
    {
        throw new NotImplementedException();
    }

    public void OnInputUp(InputEventData eventData)
    {
        throw new NotImplementedException();
    }

    // Use this for initialization
    void Start () {
        com = gameObject.GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
