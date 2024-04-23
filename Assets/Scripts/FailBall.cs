using UnityEngine;

namespace HomeWorl_2_1
{
    public class FailBall : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collider2D)
        {
            Destroy(collider2D.gameObject);
        }
    }
}