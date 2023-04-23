using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace MitsubishiAR.UI.Text
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class ChangeText : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _oldText;
        [SerializeField] private TextMeshProUGUI _newText;

        public void Change()
        {
            _oldText.text = _newText.text;
        }
    }

}
