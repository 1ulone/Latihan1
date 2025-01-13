using UnityEngine;

namespace InteractionSystem
{
    public class D_BlockController
    {
        private OnTouchInterface _onTouchInterface = new OnTouchInterface();
        public void Disappear()
        {
            _onTouchInterface.Touch(OnTouchInterface.InteractionType.DBlock);
        }
    }
}