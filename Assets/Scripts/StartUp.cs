using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEditor.SearchService;

namespace HomeWork_2_1
{
    public class StartUp : MonoBehaviour
    {
        private void Awake()
        {
            SceneManager.LoadScene("UIScene");
        }
    }
}