using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.UI.BoundsControl;
using MitsubishiAR.Components.Scene;
using static MitsubishiAR.Components.Object.States.BoxColliderStateComponent;

namespace MitsubishiAR.Components.Object.States
{
    public class ScalingStateComponent : MonoBehaviour
    {
        [SerializeField] private GameObject[] _objects;
        [SerializeField] private bool _needToSwitchBoxState;

        public void ChangeScalingState()
        {
            for (int i = 0; i < _objects.Length; i++)
            {
                SwitchBoundsControlState(_objects[i]);
                SwitchObjectManipulatorState(_objects[i]);

                if (SceneConstants.Instance.SceneInfo.BoundsOverrides == false && _needToSwitchBoxState)
                {
                    SwitchBoxColliderState(_objects[i]);
                }
            }
        }

        private void SwitchBoundsControlState(GameObject gameObject)
        {
            var bounds = gameObject.GetComponent<BoundsControl>();

            if (bounds == null)
            {
                var boundBox = gameObject.GetComponent<BoundingBox>();
                if (boundBox != null)
                    boundBox.enabled = !boundBox.enabled;
            }
            else
            {
                bounds.enabled = !bounds.enabled;
            }
        }

        private void SwitchObjectManipulatorState(GameObject gameObject)
        {
            var manipulator = gameObject.GetComponent<ObjectManipulator>();
            if (manipulator != null)
                manipulator.enabled = !manipulator.enabled;
        }
    }
}

