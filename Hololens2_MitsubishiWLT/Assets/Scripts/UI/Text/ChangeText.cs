using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace MitsubishiAR.UI.ChangeText
{
    public class ChangeText : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _targetText;
        [SerializeField] private string _text;

        public void Change()
        {
            _targetText.text = _text;
        }
    }

}
