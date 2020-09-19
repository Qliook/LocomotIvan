using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class NewBehaviourScript : MonoBehaviour
{
    public Text price_build;
    public Text price_auto;
    public Text price_click;
    float price_building;
    float price_clicker;
    float price_automatic;
    private click click;

    private void Start()
    {
        click = gameObject.GetComponent<click>();
        price_building = click.price_building;
        price_clicker = click.price_click;
        price_automatic = click.price_auto;
    }


    void Update()
    {
        price_build.text = ("Price:" + price_building);
        price_auto.text = ("Price:" + price_automatic);
        price_click.text = ("Price:" + price_clicker);

    }
}
