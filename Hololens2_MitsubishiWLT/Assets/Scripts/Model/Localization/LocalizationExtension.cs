using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitsubishiAR.Model.Localization
{
    public static class LocalizationExtension
    {
        public static string Localize(this string key)
        {
            return LocalizationManager.LM.Localize(key);
        }
    }
}

