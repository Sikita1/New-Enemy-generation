using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Point[] _spawnPoints;
    [SerializeField] private int _numberEnemies;
    [SerializeField] private float _interval;

    private WaitForSeconds _delay;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        int minInclusive = 0;

        _delay = new WaitForSeconds(_interval);

        for (int i = 0; i < _numberEnemies; i++)
        {
            Point spawnPoint = _spawnPoints[Random.Range(minInclusive, _spawnPoints.Length)];
            spawnPoint.Spawn();
            yield return _delay;
        }
    }
}
