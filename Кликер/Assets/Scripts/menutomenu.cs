﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menutomenu : MonoBehaviour
 {
    public GameObject clicker;
    [Header ("Upgrades")]
    public GameObject upgrades_auto;
    public GameObject upgrades_click;
    public GameObject upgrade_building;
    [Header ("Shops")]
    public GameObject shop_building;
    public GameObject  shop_click ;
    public GameObject  shop_auto ;
    [Header ("Shops end")]
    public GameObject shop_end_auto;
    public GameObject shop_end_click;
    public GameObject shop_end_building;
    
    
    
    
    


    public void shop_click1()
    {
        clicker.gameObject.active = false;
        upgrades_auto.gameObject.active = false;
        upgrades_click.gameObject.active = true;
        shop_end_click.gameObject.active = true;
        shop_auto.gameObject.active = true;
        shop_end_auto.gameObject.active = false;
        shop_click.gameObject.active = false;
        upgrade_building.gameObject.active = false;
        shop_end_building.gameObject.active = false;
        shop_building.gameObject.active = true;
    }
    public void shop_auto1()
    {
        clicker.gameObject.active = false;
        upgrades_auto.gameObject.active = true;
        upgrades_click.gameObject.active = false;
        shop_end_click.gameObject.active = false;
        shop_end_auto.gameObject.active = true;
        shop_click.gameObject.active = true;
        shop_auto.gameObject.active = false;
        upgrade_building.gameObject.active = false;
        shop_end_building.gameObject.active = false;
        shop_building.gameObject.active = true;
    }
    public void shop_end()
    {
        clicker.gameObject.active = true;
        upgrades_click.gameObject.active = false;
        upgrades_auto.gameObject.active = false;
        shop_click.gameObject.active = true;
        shop_auto.gameObject.active = true;
        shop_end_auto.gameObject.active = false;
        shop_end_click.gameObject.active = false;
        upgrade_building.gameObject.active = false;
        shop_end_building.gameObject.active = false;
        shop_building.gameObject.active = true;
        upgrade_building.gameObject.active = false;
    }
    public void shop_building1 ()
    {
        clicker.gameObject.active = false;
        upgrades_auto.gameObject.active = false;
        upgrades_click.gameObject.active = false;
        shop_end_click.gameObject.active = false;
        shop_auto.gameObject.active = true;
        shop_end_auto.gameObject.active = false;
        shop_click.gameObject.active = true;
        upgrade_building.gameObject.active = true;
        shop_end_building.gameObject.active = true;
        shop_building.gameObject.active = false;

    }
}

