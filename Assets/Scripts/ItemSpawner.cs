using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject Prefab;
    public ItemPool ObjectPool;
    
    private bool isReadyToCreate = true;
    //Number of objects in pool
    private const int maxNumberCreatable = 8;

    // Values for spawn rate
    private const float minSecondsToWaitUntilCreation = 0.25f;
    private const float maxSecondsToWaitUntilCreation = 0.5f;

    public void Start()
    {
        Reset();
    }
    
    public void Update()
    {
        if (isReadyToCreate)
        {
            StartCoroutine(CountdownUntilAdd());
        }
    }
    
    IEnumerator CountdownUntilAdd()
    {
        isReadyToCreate = false;
        yield return new WaitForSeconds(UnityEngine.Random.Range(minSecondsToWaitUntilCreation, maxSecondsToWaitUntilCreation));
        AddObject();
    }
    
    private void AddObject()
    {
        GameObject newObj = ObjectPool.Get();
        if (newObj != null)
            PlaceObject(newObj);
        isReadyToCreate = true;
    }
    
    private void PlaceObject(GameObject newCoffee)
    {
        newCoffee.transform.position = SpriteTools.RandomTopOfScreenWorldLocation();
    }
    
    
    private void Reset()
    {
        isReadyToCreate = true;
        ObjectPool.Create(Prefab, maxNumberCreatable);
    }
}