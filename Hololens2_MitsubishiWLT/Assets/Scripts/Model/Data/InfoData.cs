using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace MitsubishiAR.Model.Data
{
    [Serializable]
    public struct InfoData
    {
        [SerializeField] private Sentence[] _sentences;
        
        public Sentence[] Sentences => _sentences;
    }

    [Serializable]
    public struct Sentence
    {
        [SerializeField] private string _value;

        public string Value => _value;
    }
}

