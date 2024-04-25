using UnityEngine;

namespace HomeWork_2_1
{
    public class CompliteLevel : MonoBehaviour
    {
        [SerializeField] private GameObject _UI;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _UI.SetActive(false);
            }
        }
    }
}