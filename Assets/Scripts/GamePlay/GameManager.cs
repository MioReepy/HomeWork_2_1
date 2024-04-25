using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HomeWork_2_1
{
	public class GameManager : MonoBehaviour
	{
		[SerializeField] private GameObject _gameContent;
        [SerializeField] private GameObject _startUI;
        [SerializeField] private GameObject _complrtrUI;

        private void Awake()
        {
            //_gameContent.SetActive(false);
            //_startUI.SetActive(true);
        }

        //private void OnEnable()
        //{
        //    StartWindow.LevelStarted += StartWindowOnLevelStarted;
        //}

        //private void OnDisable()
        //{
        //    StartWindow.LevelStarted -= StartWindowOnLevelStarted;
        //}

        //private void StartWindowOnLevelStarted()
        //{
        //    _gameContent.SetActive(true);
        //}
    }
}