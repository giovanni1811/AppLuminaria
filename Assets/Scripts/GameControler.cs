using System;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour {

    public GameObject mainPanel;
    public GameObject menuOpcoes;
    public GameObject menuSeletor;
    public bool statusMenu { get; private set; }

    public SeletorCores sc;

	// Use this for initialization
	void Start () {
        statusMenu = false;
        menuSeletor.SetActive(false);
        mainPanel.SetActive(true);
	}

	// Update is called once per frame
	void Update () {

        if (sc.emCima && Input.GetMouseButtonDown(0))
        {
            sc.selet.podeMover = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            sc.selet.podeMover = false;
        }

        if (sc.selet.podeMover)
        {
            sc.selet.movimento();
        }
	}

    public void ativaMenu()
    {
        statusMenu = !statusMenu;
        menuOpcoes.SetActive(statusMenu);
    }

    public void ativaSeletorCores()
    {
        menuSeletor.SetActive(true);
        mainPanel.SetActive(false);
        menuOpcoes.SetActive(false);
    }

    public void fechaSeletorCores()
    {
        menuSeletor.SetActive(false);
        mainPanel.SetActive(true);
    }
}
