using UnityEngine;

namespace HomeWork_2_1
{
    public class MoveController : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private Rigidbody2D _rb;
        [SerializeField] private float _platformBorder;
        private Vector2 _startPosition = Vector2.zero;

        private void FixedUpdate()
        {
            float moveDirection = Input.GetAxisRaw("Horizontal");
            Vector3 newPosition = transform.position;

            newPosition.x = newPosition.x + moveDirection * _speed * Time.deltaTime;
            newPosition.x = Mathf.Clamp(newPosition.x, -_platformBorder, _platformBorder);
            _rb.MovePosition(newPosition);
        }
    }
}