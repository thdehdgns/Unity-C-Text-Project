using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Fruit
{
    void initData()
    {
        name = "사과";
        price = 5000;
        description = "맛있다";
    }
    protected virtual void Start()
    {
        initData();
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
