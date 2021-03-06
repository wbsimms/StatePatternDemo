﻿namespace StatePattern.Lib
{
    public class Success : State
    {

        public Success(State state)
            : this(state.Blink, state.Color, state.StateMonitor)
        {
            this.blink = state.Blink;
            this.color = state.Color;
            this.StateMonitor = state.StateMonitor;
        }

        public Success(bool blink, Colors colors, StateMonitor stateMonitor)
        {
            this.blink = blink;
            this.color = colors;
            this.StateMonitor = stateMonitor;
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