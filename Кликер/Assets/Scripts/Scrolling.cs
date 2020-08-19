using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    public Canvas canvas;
    public GameObject conteiner;
    public GameObject[] planets;
    public float scrolspeed = 7;

    Vector2 centr;
    private bool isscrol = true;
    private GameObject scrolobject;

    void Start()
    {
        centr = new Vector2(canvas.pixelRect.width / 2, canvas.pixelRect.height / 2);
    }

    void Update()
    {
        if (Input.GetMouseButton(0) || Input.GetMouseButtonUp(0))
        {
            isscrol = true;
        }
        else
        {
            float dist = float.MaxValue;
            for (int i = 0; i < planets.Length; i++)
            {
                float nowdist = Vector2.Distance(centr, new Vector2(planets[i].transform.position.x, planets[i].transform.position.y));
                if (dist > nowdist)
                {
                    dist = nowdist;
                    scrolobject = planets[i];
                }
            }
            isscrol = false;
        }

        if (!isscrol)
        {
            conteiner.GetComponent<RectTransform>().localPosition = Vector2.Lerp(conteiner.GetComponent<RectTransform>().localPosition, new Vector2(0, -scrolobject.transform.localPosition.y), scrolspeed * Time.fixedDeltaTime);
        }
    }
}