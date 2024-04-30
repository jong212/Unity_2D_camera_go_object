/*
카메라 따라다니게 하는거 관련해서 수업함
근데 시네머신 ? 사용하면 이렇게 코딩 안 해도 된다고 함
레이케스트().. 맨 앞에 검출
레이케스트올() 영역안에 있는거 레이어 통해서 검출

레이케이스트 > 디스턴스 > 매그니튜드....?
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
