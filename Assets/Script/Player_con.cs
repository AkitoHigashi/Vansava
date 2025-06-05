using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_con : MonoBehaviour
{
    private Rigidbody2D _rb;
[SerializeField] TriggerArea TriggerArea;
[SerializeField] float _speed = 1f;    // Start is called before the first frame update
void Start()
{

    _rb = GetComponent<Rigidbody2D>();

}

// Update is called once per frame
void Update()
{
    Vector3 PlayerPos = this.transform.position;
    if (TriggerArea._enemy != null)
    {
        var pos = TriggerArea._enemy.position - PlayerPos;
        _rb.transform.up = pos;
    }

    float moveX = Input.GetAxisRaw("Horizontal");
    float moveY = Input.GetAxisRaw("Vertical");

    Vector2 Move = new Vector2(moveX, moveY);

    _rb.velocity = Move * _speed;

}
}
