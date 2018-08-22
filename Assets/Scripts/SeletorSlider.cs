using System.Collections;
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

	// Use this for initialization
	void Start () {
        mexe = false;
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
            Debug.Log("PosMouse -> x: " + Input.mousePosition.x + " | y: " + Input.mousePosition.y);
            float rodaZ = toRotationZ();
            linha.transform.eulerAngles = new Vector3(0, 0, rodaZ);
            ultRotZ = rodaZ;
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

    public float toRotationZ()
    {
        Vector2 posMouse = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        float angle = Mathf.Atan2(posMouse.y, posMouse.x) * k * Mathf.Rad2Deg;

        return angle;

    }
}
