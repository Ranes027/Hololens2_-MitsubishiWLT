using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitsubishiAR.StateMachine
{
    public class AdminState : State
    {
        public AdminState(SceneContent sceneContent, StateMachine stateMachine) : base(sceneContent, stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();
            sceneContent.AdminMenu.ShowSceneObjects();
            sceneContent.AdminMenu.SwitchBoundsState();
            sceneContent.AdminMenu.ActiveMenu();
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
            sceneContent.AdminMenu.DisableMenu();
            sceneContent.AdminMenu.SwitchBoundsState();
            sceneContent.AdminMenu.HideSceneObjects();
        }
    }

}
