using UnityEngine;

namespace HomeWorl_2_1
{
    public class BlockWork : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.TryGetComponent(out BallController ball))
            {
                gameObject.SetActive(false);
            }
        }

    }
}