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

        }        

        public virtual void Exit()
        {

        }
    }
}

