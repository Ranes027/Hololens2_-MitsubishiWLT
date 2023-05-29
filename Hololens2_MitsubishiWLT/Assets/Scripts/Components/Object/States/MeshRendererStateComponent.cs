using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitsubishiAR.Components.Object.States
{
    public class MeshRendererStateComponent : SwitchComponentState
    {
        [SerializeField] private GameObject[] _objects;

        public void ChangeMeshRendererState()
        {
            for (int i = 0; i < _objects.Length; i++)
            {
                SwitchRendererState<MeshRenderer>(_objects[i]);
            }
        }

        public static void ChangeMeshRendererState(GameObject[] objects, bool state)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                SwitchRendererState<MeshRenderer>(objects[i], state);
            }
        }
    }

}
