using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private UIManager uiManager;
    [SerializeField] private ItemManager itemManager;
    [SerializeField] private Inventory inventory;

    public UIManager UIManager { get => uiManager; }
    public ItemManager ItemManager { get => itemManager; }
    public Inventory Inventory { get => inventory; }


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
            Init();
        }
        else
        {
            Debug.Log("Instance is not null");
            Destroy(this.gameObject);
        }
    }

    private void Init()
    {
        Debug.Log("Init");
        uiManager.Init();
        itemManager.Init();
        inventory.Init();
    }
}
