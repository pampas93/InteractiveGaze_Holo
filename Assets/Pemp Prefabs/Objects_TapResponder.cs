// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

//namespace HoloToolkit.Unity.InputModule.Tests

/// <summary>
/// This class implements IInputClickHandler to handle the tap gesture.
/// It increases the scale of the object when tapped.
/// </summary>
public class Objects_TapResponder : MonoBehaviour, IInputClickHandler, IInputHandler
    {

    

    public void OnInputClicked(InputClickedEventData eventData)
    {
        // Increase the scale of the object just as a response.
        gameObject.transform.localScale += 0.05f * gameObject.transform.localScale;
        //if (isActive)
        //    isActive = false;
        //else
        //    isActive = true;
        //}
    }

        public void OnInputDown(InputEventData eventData)
        {     
            gameObject.transform.localScale -= 0.01f * gameObject.transform.localScale;
             throw new NotImplementedException();
        }

        public void OnInputUp(InputEventData eventData)
        {
            gameObject.transform.localScale += 0.01f * gameObject.transform.localScale;
            throw new NotImplementedException();
        }

    void Awake()
    {
        
    }

    void Update()
    {
        

        //if (rotateLeft)
        //{
        //    this.transform.Rotate(0, 1, 0);
        //}
        //if (rotateRight)
        //{
        //    this.transform.Rotate(0, 1, 0);
        //}
    }
}
