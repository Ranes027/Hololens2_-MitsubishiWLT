using TMPro;
using UnityEngine;

namespace MitsubishiAR.UI.TextUtils
{
    public class InfoContent : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _text;

        public TextMeshProUGUI Text => _text;
    }

}
