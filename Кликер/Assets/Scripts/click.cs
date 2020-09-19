using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System; 

public class click : MonoBehaviour
{
    float add_to_click = 1;
    public float maney = 0;
    public Text numbermoney;
    public Text price_build;
    public float time;
    float deltime;
    float profit_auto = 1;
    bool start_auto = false;

    public float price_auto = 10;
    public float price_click = 100;
    public float price_building = 1000;

    private int count = 0;
    private GameObject destoring;
    public GameObject[] Buildings;
    


    // Use this for initialization
    void Start()
    {
        deltime = time;
        destoring = Instantiate(Buildings[count]);
        count++;
    }

    // Update is called once per frame
    void Update()
    {

        
        numbermoney.text = ("Money:" + maney);
        if (start_auto == true)
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                maney += profit_auto;
                time = deltime;

            }
        }
    }
    public void Click()
    {
        maney += add_to_click;

    }
    public void Autoclicker()
    {
        if (start_auto == false && maney >= price_auto)
        {
            start_auto = true;
            maney -= price_auto;
            price_auto *= 2f;


        }
        if (start_auto == true && maney >= price_auto)
        {
            profit_auto += 1;
            maney -= price_auto;
            price_auto *= 2f ;
            Math.Round(price_auto, 1);
            

        }
    }
    public void upgrade_click()
    {
        if (maney >= 100)
        {
            add_to_click += 2;
            maney -= price_click ; 
        }


    }
    public void Upgarde_building()
    {
        if(maney >= 500)
        {
            Destroy(destoring);
            destoring = Instantiate(Buildings[count]);
            count++;
            Debug.Log("Объект заспавнен " + count);
            maney -= 500;

        }
        
    }



}
