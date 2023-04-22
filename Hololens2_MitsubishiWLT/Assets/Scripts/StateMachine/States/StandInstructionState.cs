using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static MitsubishiAR.Components.Object.States.ShowObjectsComponent;
using static MitsubishiAR.Components.Object.States.HideObjectsComponent;

namespace MitsubishiAR.StateMachine
{
    public class StandInstructionState : State
    {
        public StandInstructionState(SceneContent sceneContent, StateMachine stateMachine) : base(sceneContent, stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();
            sceneContent.StandMenu.ActiveMenu();
            ShowObjects(sceneContent.StandInstObjects);
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();

            if (sceneContent.MainMenu.gameObject.activeSelf == true)
            {
                stateMachine.ChangeState(sceneContent.Idle);
                Debug.Log("State changed to Idle");
            }
        }

        public override void Exit()
        {
            base.Exit();
            sceneContent.StandMenu.DisableMenu();
            HideObjects(sceneContent.StandInstObjects);
        }
    }

}
