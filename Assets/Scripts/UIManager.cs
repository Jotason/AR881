using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.UI;
using System;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

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
        onMainMenu += OnMainMenu;
        onInventoryMenu += OnInventoryMenu;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMainMenu()
    {
        mainMenuPanel.SetActive(true);
        inventoryMenuPanel.SetActive(false);
    }

    public void OnInventoryMenu()
    {
        inventoryMenuPanel.SetActive(true);
        mainMenuPanel.SetActive(false);

    }
}
