using UnityEngine;

namespace InteractionSystem
{
    public class D_BlockController : OnTouchInterface 
    {
        private BoxCollider2D _collider2D;
        private OnTouchInterface _onTouchInterface;

        private void Start()
        {
            _collider2D = GetComponent<BoxCollider2D>();
            _onTouchInterface = FindFirstObjectByType<OnTouchInterface>();
        }

		/*
        private void OnCollisionEnter2D(Collision2D collision2D)
        {
            _onTouchInterface.Touch(OnTouchInterface.InteractionType.DBlock);
        }
		*/

        protected override void TouchEvent()
        {
//          _collider2D.isTrigger = true;
            Invoke("Disappear", 1.0f);
        }

        private void Disappear()
        {
            gameObject.SetActive(false);
        }
    }
}
