using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static MitsubishiAR.Components.Object.States.ActiveStateComponent;

namespace MitsubishiAR.StateMachine
{
    public class InfoState : State
    {
        public InfoState(SceneContent sceneContent, StateMachine stateMachine) : base(sceneContent, stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();
            ChangeState(sceneContent.Tips);
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
            ChangeState(sceneContent.Tips);
        }
    }

}
