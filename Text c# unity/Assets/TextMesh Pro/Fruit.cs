using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : Goods
{
    protected virtual  void Start()
    {
        NameText.text = $"과일 이름: {name}";
        DecriptionText.text = $"상품설명 :{description}";
        priceText.text = $"과일 가격: {price}";
    }


}

