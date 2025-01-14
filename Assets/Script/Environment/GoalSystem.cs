namespace InteractionSystem
{
    public class GoalSystem
    {
        private OnTouchInterface _onTouchInterface;
        public void Goal()
        {
            _onTouchInterface.Touch(OnTouchInterface.InteractionType.Goal);
        }
    }   
}