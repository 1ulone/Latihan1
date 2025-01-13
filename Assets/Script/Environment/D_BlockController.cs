

using System;
using UnityEditor.Timeline.Actions;
using UnityEngine;

namespace InteractionSystem
{
    public class D_BlockController : MonoBehaviour
    {
        private BoxCollider2D _collider2D;
        private OnTouchInterface _onTouchInterface;

        private void Start()
        {
            _collider2D = GetComponent<BoxCollider2D>();
            _onTouchInterface = GetComponentInParent<OnTouchInterface>();
        }

        private void OnCollisionEnter2D(Collision2D collision2D)
        {
            _onTouchInterface.Touch(OnTouchInterface.InteractionType.DBlock);
        }

        public void Touch()
        {
            _collider2D.isTrigger = true;
            Invoke("Disappear", 1.0f);
        }

        private void Disappear()
        {
            gameObject.SetActive(false);
        }
    }
}