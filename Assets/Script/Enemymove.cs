using System.Globalization;
using UnityEngine;

public class Enemymove: MonoBehaviour
{
    public GameObject player;     // �ǂ�������^�[�Q�b�g�i�v���C���[�j
    public float speed = 3f;     // �ړ����x

    void Start()
    {
        player = GameObject.Find("Yubi");
    }
    void Update()
    {
        
        if (player == null) return;
        {
            // �v���C���[�̕���������
            Vector3 direction = (player.transform.position - transform.position).normalized;

            // �G���v���C���[�����Ɉړ�
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}