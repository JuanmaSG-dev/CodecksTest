using UnityEngine;

namespace NinjaFrog
{
    public class NinjaFrogMovement : MonoBehaviour
    {
        private Rigidbody2D rb;
        private bool isGrounded = false;
        public bool estaRespawnArea = false;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                isGrounded = true;
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Respawn"))
            {
                estaRespawnArea = true;
            }
        }

        public bool getRespawnArea()
        {
            return estaRespawnArea;
        }
    }
}