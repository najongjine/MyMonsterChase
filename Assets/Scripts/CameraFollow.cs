using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Transform player;
    Vector3 tempPos;

    [SerializeField]
    float minX=-60f, maxX=60f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!player)
        {
            return;
        }
        tempPos=transform.position;
        tempPos.x=player.position.x;
        if(tempPos.x < minX)
        {
            tempPos.x=minX;
        }
        if (tempPos.x > maxX)
        {
            tempPos.x = maxX;
        }

        transform.position = tempPos;
    }
}
