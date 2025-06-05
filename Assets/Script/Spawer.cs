using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;      // ��������v���n�u
    public float interval = 2f;    // �����Ԋu�i�b�j

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            Instantiate(prefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(interval);
        }
    }
}
