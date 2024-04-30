using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public float speed;
    public Vector3 offset;
    void Start()
    {  
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dirpos = player.position + offset;
        transform.position= Vector3.Lerp(transform.position, dirpos, speed);
    }
}
