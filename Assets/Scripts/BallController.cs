using UnityEngine;

namespace HomeWork_2_1
{
    public class BallController : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rb;

        private Vector2 _startForce = new Vector2(0, 300);
        private bool _isActive = false;

        private void Awake()
        {
            _rb.bodyType = RigidbodyType2D.Kinematic;
            _startForce.x = Random.Range(-300, 300);
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
            _isActive = true;
            _rb.bodyType = RigidbodyType2D.Dynamic;
            _rb.AddForce(_startForce);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.TryGetComponent(out MoveController platform))
            {
                float contactPlatform = collision.contacts[0].point.x;
                _rb.velocity = Vector2.zero;
                float platformCenterPosition = platform.gameObject.GetComponent<Transform>().position.x;
                float differencePosition = platformCenterPosition - contactPlatform;
                float ballDirection = contactPlatform < platformCenterPosition ? -1 : 1;
                _rb.AddForce(new Vector2(ballDirection * Mathf.Abs(differencePosition * (_startForce.y / 2)), _startForce.y));
            }
        }
    }
}