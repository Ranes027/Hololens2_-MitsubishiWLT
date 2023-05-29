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
            SwitchActiveCondition(sceneContent.Tips, true);
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();            
        }

        public override void Exit()
        {
            base.Exit();
            SwitchActiveCondition(sceneContent.Tips, false);
        }
    }

}
