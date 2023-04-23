using System.Collections;
using System.Collections.Generic;
using MitsubishiAR.Model.Data;
using MitsubishiAR.UI.Text;
using UnityEngine;
using UnityEngine.Events;

namespace MitsubishiAR.Components.Info
{
    public class ShowInfoComponent : MonoBehaviour
    {
        [SerializeField] private InfoWindowController _infoWindow;
        [SerializeField] private InfoData _data;
        [SerializeField] private UnityEvent _onComplete;
        [SerializeField] private UnityEvent _onExit;

        public void Show()
        {
            _infoWindow.ShowInfo(_data, _onComplete, _onExit);
        }
    }

}
