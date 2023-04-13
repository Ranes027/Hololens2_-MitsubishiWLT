using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitsubishiAR.Components.Object.States
{
    public class MeshRendererStateComponent : MonoBehaviour
    {
        [SerializeField] private GameObject[] _objects;

        public void Active()
        {
            for (int i = 0; i < _objects.Length; i++)
            {
                SwitchMeshRendererState(_objects[i]);
            }
        }

        public static void SwitchMeshRendererState(GameObject gameObject)
        {
            var mesh = gameObject.GetComponent<MeshRenderer>();
            if (mesh != null)
                mesh.enabled = !mesh.enabled;
            else
                Debug.Log("Add MeshRenderer to object!");
        }
    }

}
