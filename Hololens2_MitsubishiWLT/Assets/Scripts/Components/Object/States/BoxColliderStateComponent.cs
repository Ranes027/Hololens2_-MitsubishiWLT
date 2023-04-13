using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitsubishiAR.Components.Object.States
{
    public class BoxColliderStateComponent : MonoBehaviour
    {
        [SerializeField] private GameObject[] _objects;

        public void Active()
        {
            for (int i = 0; i < _objects.Length; i++)
            {
                SwitchBoxColliderState(_objects[i]);
            }
        }

        public static void SwitchBoxColliderState(GameObject gameObject)
        {
            var box = gameObject.GetComponent<BoxCollider>();
            if (box != null)
                box.enabled = !box.enabled;
            else
                Debug.Log("Add BoxCollider to object!");
        }
    }

}
