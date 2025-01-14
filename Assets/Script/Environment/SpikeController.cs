namespace InteractionSystem
{
    public class SpikeController
    {
        private OnTouchInterface _onTouchInterface;
        public void Spike()
        {
            _onTouchInterface.Touch(OnTouchInterface.InteractionType.Spike);
        }
    }   
}
