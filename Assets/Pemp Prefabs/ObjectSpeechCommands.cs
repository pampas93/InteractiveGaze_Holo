using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class ObjectSpeechCommands : MonoBehaviour,ISpeechHandler {

    private Material cachedMaterial;
    private Color defaultColor;
    private HandResize resizeObj;
    private HandRotate rotateObj;
 
    private Transform x;

    public void OnSpeechKeywordRecognized(SpeechKeywordRecognizedEventData eventData)
    {
        ChangeColor(eventData.RecognizedText);
        throw new NotImplementedException();
    }

    void Awake()
    {
        x = this.gameObject.transform;
        cachedMaterial = GetComponent<Renderer>().material;
        defaultColor = cachedMaterial.color;
    }
    // Use this for initialization
    void Start () {

        resizeObj = GetComponent<HandResize>();
        rotateObj = GetComponent<HandRotate>();
        resizeObj.enabled = false;
        rotateObj.enabled = false;

    }

    // Update is called once per frame
    void Update () {
		
	}

    public void ChangeColor(string color)
    {
        switch (color.ToLower())
        {
            case "red":
                cachedMaterial.SetColor("_Color", Color.red);
                break;
            case "blue":
                cachedMaterial.SetColor("_Color", Color.blue);
                break;
            case "green":
                cachedMaterial.SetColor("_Color", Color.green);
                break;
            case "black":
                cachedMaterial.SetColor("_Color", Color.black);
                break;
            case "white":
                cachedMaterial.SetColor("_Color", Color.white);
                break;
            case "yellow":
                cachedMaterial.SetColor("_Color", Color.yellow);
                break;
            case "rotate object":
                rotateObj.enabled = true;
                resizeObj.enabled = false;
                break;
            case "scale object":
                resizeObj.enabled = true;
                rotateObj.enabled = false;
                break;
            case "reset object":
                this.gameObject.transform.localScale = x.localScale;
                this.gameObject.transform.localRotation = x.localRotation;
                break;
            case "editing done":
                resizeObj.enabled = false;
                rotateObj.enabled = false;
                break;
        }
    }

    public void ResetColor()
    {
        cachedMaterial.SetColor("_Color", defaultColor);
    }

    private void OnDestroy()
    {
        DestroyImmediate(cachedMaterial);
    }
}
