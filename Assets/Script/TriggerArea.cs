using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    private const string _Enemytag = "Enemy";
    public Transform _enemy = null;
    private List<Transform> _EnemyInRange = new List<Transform>();

    [SerializeField] Transform Player;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(_Enemytag))
        {
            _enemy = other.transform;
            _EnemyInRange.Add(other.transform);

            Debug.Log("オブジェクトがトリガーに入った: " + other.name);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag(_Enemytag))
        {
            _EnemyInRange.Remove(other.transform);
            Debug.Log("オブジェクトがトリガーから出た: " + other.name);
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_EnemyInRange.Count > 0 && Player != null)
        {
            _enemy =GetClosestEnemy();
        }
        else
        {
            _enemy = null;
        }
    }
    private Transform GetClosestEnemy()
    {
        Transform closest = null;
        float minDistance = float.MaxValue;
        foreach (var enemy in _EnemyInRange)
        {
            float dist = Vector2.Distance(Player.position, enemy.position);
            if (dist < minDistance)
            {
                minDistance = dist;
                closest = enemy;
            }
        }
        return closest;
    }
}
