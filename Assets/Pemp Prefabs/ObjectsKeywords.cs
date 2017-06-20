// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;
using HoloToolkit.Unity.InputModule;


    [RequireComponent(typeof(Renderer))]
    public class ObjectsKeywords : MonoBehaviour, ISpeechHandler
    {
        private Material cachedMaterial;
        private Color defaultColor;
    public GameObject menuObject;

        private void Awake()
        {
            cachedMaterial = GetComponent<Renderer>().material;
            defaultColor = cachedMaterial.color;
        menuObject.SetActive(false);
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
            case "open menu":
                menuObject.SetActive(true);
                break;
            case "close menu":
                menuObject.SetActive(false);
                break;

        }
        }

        public void ResetColor()
        {
            cachedMaterial.SetColor("_Color", defaultColor);
        }

        public void OnSpeechKeywordRecognized(SpeechKeywordRecognizedEventData eventData)
        {
            ChangeColor(eventData.RecognizedText);
        }

        private void OnDestroy()
        {
            DestroyImmediate(cachedMaterial);
        }
    }
