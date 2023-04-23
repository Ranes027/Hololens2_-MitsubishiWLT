using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace MitsubishiAR.UI.Text
{
    public class InfoContent : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _text;

        public TextMeshProUGUI Text => _text;
    }

}
