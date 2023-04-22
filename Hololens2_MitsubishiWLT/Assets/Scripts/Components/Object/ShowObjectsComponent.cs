using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitsubishiAR.Components.Object.States
{
    public class ShowObjectsComponent : MonoBehaviour
    {
        [SerializeField] private GameObject[] _objects;

        public void Show()
        {
            ShowObjects(_objects);
        }

        public static void ShowObjects(GameObject[] objects)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].SetActive(true);
            }
        }
    }
}
