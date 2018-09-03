using System;
using System.Collections.Generic;
using UnityEngine;

public class SeletorSlider : MonoBehaviour {

    //public bool podeMover;
    public GameObject linha;
    public bool mexe;
    public Vector3 ultPosMouse;
    public CircleSlider circleSlider;
    public float ultRotZ;
    public float k;
    public GameObject centroCircunferencia;
    public float raio { get; private set; }
    public GameObject target;

	// Use this for initialization
	void Start () {
        mexe = false;
        raio = 242;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0) && circleSlider.emCima)
        {
            mexe = true;
            cancelFreezePos();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            mexe = false;
        }

        if (mexe)
        {
            movimento();
        }
        else
        {
            ativaFreezePos();
        }
        

        ultPosMouse = Input.mousePosition;
    }

    public void ativaFreezePos()
    {
        Rigidbody2D rbLinha = linha.GetComponent<Rigidbody2D>();

        rbLinha.constraints = RigidbodyConstraints2D.FreezeAll;
    }

    public void cancelFreezePos()
    {
        Rigidbody2D rbLinha = linha.GetComponent<Rigidbody2D>();

        rbLinha.constraints = RigidbodyConstraints2D.None;
    }

    public void movimento()
    {
        Vector3 posMouse = Input.mousePosition;
        Vector2 centroCircunf = new Vector2(centroCircunferencia.transform.position.x, centroCircunferencia.transform.position.y);

        var dir = posMouse - Camera.main.WorldToScreenPoint(centroCircunferencia.transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        linha.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

    }
}
