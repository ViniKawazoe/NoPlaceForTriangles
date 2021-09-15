using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField] private GameObject room;
    [SerializeField] private int nRooms = 10;

    private int matrixSide = 5;

    #region Singleton
    public static MapGenerator Instance;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #endregion

    public void GenerateMap()
    {
        
    }
}