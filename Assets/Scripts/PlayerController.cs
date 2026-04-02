using UnityEngine;

namespace MyGame.Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerController : MonoBehaviour
    {
        [Header("Movement Settings")]
        [SerializeField] private float moveSpeed = 5;
        private float horizontalInput;

        private Rigidbody2D playerRigidbody2D;

        private void Awake()
        {
            playerRigidbody2D = GetComponent<Rigidbody2D>();
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
    }
}