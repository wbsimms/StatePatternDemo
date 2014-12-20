namespace StatePattern.Lib
{
    public class StateMonitor
    {
        public State State { get; set; }

        public StateMonitor()
        {
            this.State = new Success(false, Colors.Green,this);
        }

        public void ShouldBlink(bool shouldBlink)
        {
            this.State.ShouldBlinkLight(shouldBlink);
        }

        public void ChangeColor(Colors newColor)
        {
            this.State.ChangeColor(newColor);
        }

    }
}