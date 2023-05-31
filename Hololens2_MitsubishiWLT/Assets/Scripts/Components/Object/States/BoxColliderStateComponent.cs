using UnityEngine;

namespace MitsubishiAR.Components.Object.States
{
    public class BoxColliderStateComponent : SwitchComponentState
    {
        [SerializeField] private GameObject[] _objects;

        public void ChangeBoxColliderState()
        {
            for (int i = 0; i < _objects.Length; i++)
            {
                SwitchColliderState<BoxCollider>(_objects[i]);
            }
        }
    }

}
