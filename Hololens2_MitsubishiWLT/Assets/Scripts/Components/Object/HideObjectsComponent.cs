using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitsubishiAR.Components.Object.States
{
    public class HideObjectsComponent : MonoBehaviour
    {
        [SerializeField] private GameObject[] _objects;

        public void Hide()
        {
            HideObjects(_objects);
        }

        public static void HideObjects(GameObject[] objects)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].SetActive(false);
            }
        }
    }
}

