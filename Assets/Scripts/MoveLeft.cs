﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    [SerializeField]
    private float speed = 1f;
    [SerializeField]
    private float randomOffset = 2f;

    private void Update()
    {
        transform.position += Time.deltaTime * speed * Vector3.left;
        if (transform.position.x <= -15)
        {
            float randomHeight = UnityEngine.Random.Range(-randomOffset, randomOffset); 
            transform.position = new Vector3(15, randomHeight, transform.position.z);
        }
    }
}
