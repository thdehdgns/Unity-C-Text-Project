using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Fruit
{
    void initData()
    {
        name = "바바나";
        price = 5500;
        description = "길다";
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
