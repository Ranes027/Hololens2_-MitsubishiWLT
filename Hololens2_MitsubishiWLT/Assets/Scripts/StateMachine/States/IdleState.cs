using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MitsubishiAR.Components.Object.States;
using MitsubishiAR.Components.Scene;

namespace MitsubishiAR.StateMachine
{
    public class IdleState : State
    {
        public IdleState(SceneContent sceneContent, StateMachine stateMachine) : base(sceneContent, stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();
            sceneContent.UpdateSceneAnimator(sceneContent.SceneContentAnimator);        
            sceneContent.MainMenu.ActiveMenu();
            sceneContent.HandMenu.ActiveMenu();       
            sceneContent.HandMenu.MainMenuMode();
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();

            if (sceneContent.AdminMenu.gameObject.activeSelf == true)
            {
                stateMachine.ChangeState(sceneContent.Admin);
                Debug.Log("State changed to Admin");
            }
        }

        public override void LateEnter()
        {
            base.LateEnter();
            sceneContent.AdminMenu.SwitchBoundsState();
        }

        public override void Exit()
        {
            base.Exit();
            sceneContent.MainMenu.DisableMenu();
            sceneContent.HandMenu.OutOfMainMenuMode();
        }
    }

}
