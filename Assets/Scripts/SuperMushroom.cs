using UnityEngine;

public class SuperMushroom : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out MyGame.Player.PlayerController player))
        {
            player.Grow();
            Destroy(gameObject);
        }
    }
}