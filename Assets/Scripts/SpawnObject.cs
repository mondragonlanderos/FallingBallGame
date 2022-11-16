using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField] GameObject[] gameObjectPrefab;
    [SerializeField] float secondSpawn = 0.5f;
    [SerializeField] float xMin;
    [SerializeField] float xMax;
    //public GameObject GameObjectPrefab;
    //public float Radius = 1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObjectAtRandom());
    }

    IEnumerator SpawnObjectAtRandom()
    {
        while (true)
        {
            var xPos = Random.Range(xMin, xMax);
            var position = new Vector3(xPos, transform.position.y);
            GameObject gameObject = Instantiate(gameObjectPrefab[Random.Range(0, gameObjectPrefab.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);
        }
    }

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //        SpawnObjectAtRandom();
    //}

    //void SpawnObjectAtRandom()
    //{
    //    Vector3 randomPos = Random.insideUnitCircle * Radius;
    //    Instantiate(GameObjectPrefab, randomPos, Quaternion.identity); 
    //}
}
