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
            sceneContent.AdminMenu.SceneObjectsState(true);
            sceneContent.AdminMenu.SwitchBoundsState(true);
            sceneContent.AdminMenu.MenuState(true);
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();
        }

        public override void Exit()
        {
            base.Exit();
            sceneContent.AdminMenu.MenuState(false);
            sceneContent.AdminMenu.SwitchBoundsState(false);
            sceneContent.AdminMenu.SceneObjectsState(false);
        }
    }

}
