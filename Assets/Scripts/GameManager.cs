using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public event Action onMainMenu;
    public event Action onInventoryMenu;

    public GameObject mainMenuPanel;
    public GameObject inventoryMenuPanel;



    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    void Start()
    {
       OnMainMenu();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMainMenu()
    {
        onMainMenu?.Invoke();
    }

    public void OnInventoryMenu()
    {
        onInventoryMenu?.Invoke();

    }

    public void CloseApplication() { 
    Application.Quit();
    }
}
