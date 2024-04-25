using UnityEngine;
using UnityEngine.SceneManagement;

namespace HomeWork_2_1
{
    public class FailBall : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collider2D)
        {
            if (collider2D.TryGetComponent(out BallController ball))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}