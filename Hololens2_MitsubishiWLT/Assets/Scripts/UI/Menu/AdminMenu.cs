using System.Dynamic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace MitsubishiAR.UI
{
    public class AdminMenu : MenuWindow
    {
        [SerializeField] private UnityEvent _showObjects;
        [SerializeField] private UnityEvent _hideObjects;
        [SerializeField] private UnityEvent _boundsState;

        public void ShowSceneObjects()
        {
            _showObjects?.Invoke();
        }

        public void HideSceneObjects()
        {
            _hideObjects?.Invoke();
        }

        public void SwitchBoundsState()
        {
            _boundsState?.Invoke();
        }
    }

}
