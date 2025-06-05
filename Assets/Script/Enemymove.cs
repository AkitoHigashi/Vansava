using System.Globalization;
using UnityEngine;

public class Enemymove: MonoBehaviour
{
    public GameObject player;     // 追いかけるターゲット（プレイヤー）
    public float speed = 3f;     // 移動速度

    void Start()
    {
        player = GameObject.Find("Yubi");
    }
    void Update()
    {
        
        if (player == null) return;
        {
            // プレイヤーの方向を向く
            Vector3 direction = (player.transform.position - transform.position).normalized;

            // 敵をプレイヤー方向に移動
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}