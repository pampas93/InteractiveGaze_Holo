using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR.WSA.Input;

public class GazeHandler : MonoBehaviour {

    //private Color startColor;
    //GestureRecognizer recognizer;
    Renderer com;

    private void Awake()
    {
        //recognizer = new GestureRecognizer();
        //recognizer.TappedEvent += (source, tapCount, ray) =>
        //{
        //    TapOccured();
        //};
        //recognizer.StartCapturingGestures();
    }

    // Use this for initialization
    void Start()
    {
        com = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnGazeEnter()
    {
        //var com = gameObject.GetComponent<Renderer>();
        //startColor = com.material.color;
        com.material.color = Color.yellow;
        //recognizer.StartCapturingGestures();
    }

    void OnGazeExit()
    {
        //var com = gameObject.GetComponent<Renderer>();
        com.material.color = Color.red;
        //recognizer.CancelGestures();
    }

    void TapOccured()
    {
        var com = gameObject.GetComponent<Renderer>();
        com.material.color = Color.green;
    }

    public void OnSpeechKeywordRecognized(SpeechKeywordRecognizedEventData eventData)
    {
        var voiceCommand = eventData.RecognizedText.ToLower();

        switch (voiceCommand)
        {
            case "change color":
                {
                    VoiceColorChange();
                    break;
                }
            case "reset":
                {
                    ResetColor();
                    break;
                }
            default:
                break;
        }
    }

    public void VoiceColorChange()
    {
        com.material.color = Color.blue;

    }
    public void ResetColor()
    {
        com.material.color = Color.white;
       // selected = false;
    }
    //void TapMessage()
    //{
    //    var com = gameObject.GetComponent<Renderer>();
    //    com.material.color = Color.blue;
    //}
}
