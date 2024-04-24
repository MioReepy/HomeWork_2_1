using UnityEngine;

namespace HomeWork_2_1
{
    public class BallController : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rb;
        [SerializeField] private Vector2 _startForce = new Vector2(1, 300);
        private bool _isActive = false;
        private float _lastPosition;

        private void Awake()
        {
            _rb.bodyType = RigidbodyType2D.Kinematic;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && !_isActive)
            {
                BallActive();
            }
        }

        private void BallActive()
        {
            _lastPosition = transform.position.x;
            _isActive = true;
            _rb.bodyType = RigidbodyType2D.Dynamic;
            _rb.AddForce(_startForce);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            float ballPosition = transform.position.x;

            if (collision.gameObject.TryGetComponent(out GameObject platform))
            {
                if (ballPosition < _lastPosition + 0.1 && ballPosition > _lastPosition - 0.1)
                {
                    float _contactPlatform = collision.contacts[0].point.x;
                    _rb.velocity = Vector2.zero;
                    float platformCenterPosition = platform.gameObject.transform.position.x;
                    float differencePosition = platformCenterPosition - _contactPlatform;
                    float ballDirection = _contactPlatform < platformCenterPosition ? - 1 : 1;
                    _rb.AddForce (new Vector2(ballDirection * Mathf.Abs(differencePosition * (_startForce.x / 2)), _startForce.x));
                }
            }
        }
    }
}