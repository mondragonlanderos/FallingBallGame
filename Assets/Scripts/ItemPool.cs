using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPool : MonoBehaviour
{
    private GameObject prefab;
    private List<GameObject> unused = new List<GameObject>();
    private List<GameObject> used = new List<GameObject>();
    
    public void Create(GameObject prefabIn, int count)
    {
        Reset();
        prefab = prefabIn;
        CreateAllObjects(count);
    }

    public GameObject Get()
    {
        if (AreNoUnusedObjects())
            return null;

        GameObject objectToReturn = GetNextUnusedObject();
        UpdateListsForGetting(objectToReturn);
        objectToReturn.SetActive(true);

        return objectToReturn;
    }
    
    public void Return(GameObject objectToReturn)
    {
        UpdateListsForReturning(objectToReturn);
        objectToReturn.SetActive(false);
    }

    private void CreateAllObjects(int count)
    {
        for (int i = 0; i < count; i++)
        {
            GameObject newObject = Instantiate(prefab, new Vector3(0f, 0f, 0f), Quaternion.identity);
            newObject.SetActive(false);
            unused.Add(newObject);
        }
    }
    
    private void Reset()
    {
        DestroyExistingObjects();
        
        unused = new List<GameObject>();
        used = new List<GameObject>();
    }
    
    private void DestroyExistingObjects()
    {
        foreach (GameObject unusedObeject in unused)
        {
            Destroy(unusedObeject);
        }
        foreach (GameObject usedObeject in used)
        {
            Destroy(usedObeject);
        }
    }
    
    private void UpdateListsForGetting(GameObject objectToReturn)
    {
        unused.Remove(objectToReturn);
        used.Add(objectToReturn);
    }
    
    private GameObject GetNextUnusedObject()
    {
        GameObject objectToReturn = unused[0];
        return objectToReturn;
    }
    
    private bool AreNoUnusedObjects()
    {
        return unused.Count == 0;
    }
    
    private void UpdateListsForReturning(GameObject objectToReturn)
    {
        if (used.Contains(objectToReturn))
            used.Remove(objectToReturn);
        
        if (!unused.Contains(objectToReturn)) {
            unused.Add(objectToReturn);
        }
    }
}