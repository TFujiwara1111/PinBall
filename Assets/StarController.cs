﻿using UnityEngine;
using System.Collections;

public class StarController : MonoBehaviour
{
    //回転速度
    private float rotSpeed = 0.5f;

    //Use this for initialization
    void Start()
    {
        //回転する角度を設定
        this.transform.Rotate(0, Random.Range(0, 360), 0);
    }

    // Update is called once per frame
    void Update()
    {
        //回転
        this.transform.Rotate(0, this.rotSpeed, 0);
    }
}
