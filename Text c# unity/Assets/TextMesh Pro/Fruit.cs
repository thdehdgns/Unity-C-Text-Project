using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : Goods
{
    protected virtual  void Start()
    {
        NameText.text = $"���� �̸�: {name}";
        DecriptionText.text = $"��ǰ���� :{description}";
        priceText.text = $"���� ����: {price}";
    }


}

