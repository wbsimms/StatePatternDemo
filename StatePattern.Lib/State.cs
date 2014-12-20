using System;

namespace StatePattern.Lib
{
    public abstract class State
    {
        protected bool blink;
        protected Colors color;

        public StateMonitor StateMonitor { get; set; }

        public Colors Color
        {
            get { return color; }
        }

        public bool Blink
        {
            get { return blink; }
        }

        public void PrintState()
        {
            Console.WriteLine("===============");
            Console.WriteLine("blink : "+this.blink);
            Console.WriteLine("color : " + this.color.ToString());
            Console.WriteLine("===============");
        }

        public abstract void ShouldBlinkLight(bool shouldblink);
        public abstract void ChangeColor(Colors color);

    }
}