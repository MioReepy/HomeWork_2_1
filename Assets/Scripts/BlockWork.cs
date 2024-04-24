using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace HomeWork_2_1
{
    public class BlockWork : MonoBehaviour
    {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private List<GameObject> _sprites;
        [SerializeField] private int _score;
        [SerializeField] private int _life;

        private int _currentLife;

        private void Start()
        {
            _currentLife = _life;
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.TryGetComponent(out BallController ball))
            {
                ApplyDomage();
            }
        }

        private void ApplyDomage()
        {
            if (_life < 1)
            {
                _prefab.SetActive(false);
                CommonData._currentScore += _score;
            }
            else
            {
                _sprites[_life - 1].gameObject.SetActive(true);
            }

            _life--;
        }
    }
}