/*
ī�޶� ����ٴϰ� �ϴ°� �����ؼ� ������
�ٵ� �ó׸ӽ� ? ����ϸ� �̷��� �ڵ� �� �ص� �ȴٰ� ��
�����ɽ�Ʈ().. �� �տ� ����
�����ɽ�Ʈ��() �����ȿ� �ִ°� ���̾� ���ؼ� ����

�������̽�Ʈ > ���Ͻ� > �ű״�Ʃ��....?
 */

using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class input : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float speed = 5.0f;
        float moveHor = Input.GetAxis("Horizontal");
        float moveVer = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHor, moveVer) * speed * Time.deltaTime;
        transform.Translate(movement);
    }
}
