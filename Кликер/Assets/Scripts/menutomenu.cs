using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menutomenu : MonoBehaviour
 {

    public GameObject  shop_click ;
    public GameObject  shop_auto ;
    public GameObject shop_end_auto;
    public GameObject shop_end_click;
    public GameObject clicker;
    public GameObject upgrades_auto;
    public GameObject upgrades_click;
    public GameObject shop_building;
    public GameObject shop_end_building;
    public GameObject upgrade_building;
    public GameObject[][] Upgrade_Buttons;
    int count;

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
    public void dsg()
    {
        GameObject[][] Upgarde_Buttons = new GameObject[3][]; 
        Instantiate(Upgrade_Buttons[count])
    }
        
   

}

