using UnityEngine;

namespace MyGame.Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerController : MonoBehaviour
    {
        [Header("Movement Settings")]
        [SerializeField] private float moveSpeed = 5;
        private float horizontalInput;

        [Header("Power Up State")]
        [SerializeField] private float sizeMultiplier = 2;
        public bool isBig { get; private set; } = false;

        private Rigidbody2D playerRigidbody2D;

        private void Awake()
        {
            playerRigidbody2D = GetComponent<Rigidbody2D>();
            playerRigidbody2D.freezeRotation = true;
        }

        private void Update()
        {
            horizontalInput = Input.GetAxisRaw("Horizontal");
        }

        private void FixedUpdate()
        {
            Move();
        }

        private void Move()
        {
            playerRigidbody2D.linearVelocity = new Vector2(horizontalInput * moveSpeed, playerRigidbody2D.linearVelocity.y);
        }

        public void Grow()
        {
            if (isBig) return;
            isBig = true;

            Vector3 newScale = transform.localScale;
            newScale.y *= sizeMultiplier;
            transform.localScale = newScale;
        }
    }
}