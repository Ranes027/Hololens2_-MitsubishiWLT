using static MitsubishiAR.Components.Object.States.ActiveStateComponent;

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
            sceneContent.StandMenu.MenuState(true);
            SwitchActiveCondition(sceneContent.StandInstObjects, true);
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();
        }

        public override void Exit()
        {
            base.Exit();
            sceneContent.StandMenu.MenuState(false);
            SwitchActiveCondition(sceneContent.StandInstObjects, false);
        }
    }

}
