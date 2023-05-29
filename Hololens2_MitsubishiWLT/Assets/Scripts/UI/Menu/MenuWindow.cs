using System.Dynamic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MitsubishiAR.StateMachine;

namespace MitsubishiAR.UI
{
    public class MenuWindow : MonoBehaviour
    {   
        [SerializeField] private GameObject _menu;

        public virtual void MenuState(bool state)
        {
            _menu.SetActive(state);
        }

        public virtual void ChangeStateFromMenu(string stateName)
        {
            var sceneContent = FindObjectOfType<SceneContent>();
            if (sceneContent != null)
            {
                switch (stateName)
                {
                    case "Info":
                        sceneContent.SceneSM.ChangeState(sceneContent.Info);
                        break;
                    case "StandInstruction":
                        sceneContent.SceneSM.ChangeState(sceneContent.StandInstruction);
                        break;
                    case "ControllerCheckUp":
                        sceneContent.SceneSM.ChangeState(sceneContent.ControllerCheckUp);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Debug.Log("Add SceneContent to scene!");
            }

        }

        public virtual void ChangeRuntimeAnimatorFromMenu(RuntimeAnimatorController animator)
        {
            var sceneContent = FindObjectOfType<SceneContent>();
            if(sceneContent != null)
            {
                sceneContent.UpdateSceneAnimator(animator);
            }
        }
    }

}
