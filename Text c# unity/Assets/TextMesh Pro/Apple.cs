using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Fruit
{
    void initData()
    {
        name = "���";
        price = 5000;
        description = "���ִ�";
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
