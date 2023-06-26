using UnityEngine;
using UnityEngine.XR.WSA;
using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine.UI;
using Microsoft.MixedReality.Toolkit.Experimental.Utilities;
using System;

namespace MitsubishiAR.Components.Object
{
    public class AnchorsComponent : MonoBehaviour
    {
        [Header("UI Buttons")]
        [SerializeField] private Interactable _anchorButton;
        [SerializeField] private Interactable _saveButton;
        [SerializeField] private Interactable _loadButton;

        [SerializeField] private GameObject[] _objectsToAnchor;

        private WorldAnchorManager anchorManager;

        private void Start()
        {
            anchorManager = GetComponent<WorldAnchorManager>();

            _anchorButton.OnClick.AddListener(CreateAnchors);
            _saveButton.OnClick.AddListener(SaveAnchors);
            _loadButton.OnClick.AddListener(LoadAnchors);
        }


        private void CreateAnchors()
        {
            
        }

        private void SaveAnchors()
        {
            Debug.Log("Anchors saved");
        }

        private void LoadAnchors()
        {
            throw new NotImplementedException();
        }
    }

}
