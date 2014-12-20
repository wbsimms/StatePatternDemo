namespace StatePattern.Lib
{
    public class FailedBuilding : State
    {

        public FailedBuilding(State state)
        {
            this.blink = state.Blink;
            this.color = state.Color;
            this.StateMonitor = state.StateMonitor;
        }

        public override void ShouldBlinkLight(bool shouldblink)
        {
            this.blink = shouldblink;
            StateChangeCheck();
        }

        public override void ChangeColor(Colors color)
        {
            this.color = color;
            StateChangeCheck();
        }

        protected void StateChangeCheck()
        {
            this.StateMonitor.State = StateFactory.GetState(this);
        }
    }
}