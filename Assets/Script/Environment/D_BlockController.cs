namespace InteractionSystem
{
    public class D_BlockController
    {
        private OnTouchInterface _onTouchInterface;
        public void Disappear()
        {
            _onTouchInterface.Touch(OnTouchInterface.InteractionType.DBlock);
        }
    }
}