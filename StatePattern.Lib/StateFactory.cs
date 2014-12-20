namespace StatePattern.Lib
{
    public class StateFactory
    {
        public static State GetState(State currentState)
        {
            if (currentState.Color == Colors.Red && currentState.Blink)
            {
                return new FailedBuilding(currentState);
            }

            if (currentState.Color == Colors.Red && !currentState.Blink)
            {
                return new Failed(currentState);
            }

            if (currentState.Color == Colors.Green && currentState.Blink)
            {
                return new SuccessBuilding(currentState);
            }

            if (currentState.Color == Colors.Green && !currentState.Blink)
            {
                return new Success(currentState);
            }

            if (currentState.Color == Colors.Yellow && currentState.Blink)
            {
                return new ErrorBuilding(currentState);
            }

            if (currentState.Color == Colors.Yellow && !currentState.Blink)
            {
                return new Error(currentState);
            }
            return new Error(currentState);
        }
    }
}