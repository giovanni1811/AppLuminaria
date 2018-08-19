using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeletorSlider : MonoBehaviour {

    public bool podeMover;
    public GameObject linha;
    public bool mexe;
    public Vector3 ultPosMouse;
    public CircleSlider circleSlider;

	// Use this for initialization
	void Start () {
        podeMover = false;
        mexe = false;
	}
	
	// Update is called once per frame
	void Update () {

        linha.transform.Rotate(new Vector3(0, 0, 0));

        if (Input.GetMouseButtonDown(0) && circleSlider.emCima)
        {
            mexe = true;
        }
        else if (Input.GetMouseButtonUp(0) && mexe)
        {
            mexe = false;
        }

        if (mexe)
        {
            float direcao = ladoMexe();
            linha.transform.Rotate(new Vector3(0, 0, direcao*2));
        }
        else
        {
            linha.transform.Rotate(new Vector3(0, 0, 0));
        }

        ultPosMouse = Input.mousePosition;
    }

    public float ladoMexe()
    {
        Vector3 posMouse = Input.mousePosition;
        if (posMouse.x > ultPosMouse.x)
        {
            return -1f;
        }
        else if (posMouse.x < ultPosMouse.x)
        {
            return 1;
        }
        return 0;
    }
}
