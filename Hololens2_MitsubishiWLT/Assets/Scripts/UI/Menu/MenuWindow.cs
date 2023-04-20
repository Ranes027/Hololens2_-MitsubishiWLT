using System.Dynamic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitsubishiAR.UI
{
    public class MenuWindow : MonoBehaviour
    {   
        [SerializeField] private GameObject _menu;

        public virtual void ActiveMenu()
        {
            _menu.SetActive(true);
        }

        public virtual void DisableMenu()
        {
            _menu.SetActive(false);
        }
    }

}
