using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HomeWork_2_1
{
    public class FailBall : MonoBehaviour
    {
        [SerializeField] private GameObject _UI;

        public static bool _isFail = false;

        private void OnTriggerEnter2D(Collider2D collider2D)
        {
            if (collider2D.TryGetComponent(out BallController ball))
            {
                _isFail = true;
                _UI.gameObject.SetActive(false);
                Destroy(ball);
            }
        }
    }
}