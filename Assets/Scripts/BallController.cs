using UnityEngine;

namespace HomeWorl_2_1
{
    public class BallController : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rb;
        [SerializeField] private Vector2 _startForce = new Vector2(0, 300);

        private void Awake()
        {
            _rb.bodyType = RigidbodyType2D.Kinematic;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0) && _rb.bodyType == RigidbodyType2D.Kinematic)
            {
                _rb.bodyType = RigidbodyType2D.Dynamic;
                _rb.velocity = Vector2.zero;
                _rb.AddForce(_startForce);
            }
        }
        private void StartBall()
        {
            Create
        }
    }
}