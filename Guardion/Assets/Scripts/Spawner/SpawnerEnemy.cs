using System.Collections;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    [SerializeField] private float _speedSpawn;
    [SerializeField] private GameObject _enemy;
    private bool _repeat = true;

    float posX, posYMax, posYMin;
   
    void Start()
    {
        CalcSpawnPos();
        StartCoroutine(SpawnEnemy());
    }

    private void CalcSpawnPos()
    {
        posX = transform.transform.position.x;
        posYMax = transform.position.y + transform.localScale.y / 2;
        posYMin = transform.position.y - transform.localScale.y / 2;
    }

    IEnumerator SpawnEnemy()
    {

        while (_repeat)
        {
            yield return new WaitForSeconds(_speedSpawn);
            Instantiate(_enemy, new Vector3(posX, Random.Range(posYMin, posYMax), 0), Quaternion.identity);
        }
    }
}
