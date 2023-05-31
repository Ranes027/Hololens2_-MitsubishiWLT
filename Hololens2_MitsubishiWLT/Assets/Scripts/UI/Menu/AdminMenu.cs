using UnityEngine;
using static MitsubishiAR.Components.Object.States.ActiveStateComponent;
using static MitsubishiAR.Components.Object.States.MeshRendererStateComponent;
using static MitsubishiAR.Components.Object.States.ScalingStateComponent;

namespace MitsubishiAR.UI
{
    public class AdminMenu : MenuWindow
    {
        [SerializeField] private GameObject[] _objects;
        [SerializeField] private GameObject[] _meshes;
        [SerializeField] private GameObject[] _bounds;

        public void SceneObjectsState(bool state)
        {
            SwitchActiveCondition(_objects, state);
            ChangeMeshRendererState(_meshes, state);
        }

        public void SwitchBoundsState()
        {
            ChangeScalingState(_bounds);
        }

        public void SwitchBoundsState(bool state)
        {
            ChangeScalingState(_bounds, state);
        }
    }

}
