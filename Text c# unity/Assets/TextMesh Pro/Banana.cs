using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Fruit
{
    void initData()
    {
        name = "�ٹٳ�";
        price = 5500;
        description = "���";
    }
    void Start()
    {
        initData();
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
