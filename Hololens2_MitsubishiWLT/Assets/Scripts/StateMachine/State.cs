namespace MitsubishiAR.StateMachine
{
    public abstract class State
    {
        protected SceneContent sceneContent;
        protected StateMachine stateMachine;

        protected State(SceneContent sceneContent, StateMachine stateMachine)
        {
            this.sceneContent = sceneContent;
            this.stateMachine = stateMachine;
        }

        public virtual void Enter()
        {

        }

        public virtual void LateEnter()
        {

        }

        public virtual void LogicUpdate()
        {
            if (sceneContent.MainMenu.gameObject.activeSelf == true)
            {
                stateMachine.ChangeState(sceneContent.Idle);
            }
        }

        public virtual void Exit()
        {

        }
    }
}

