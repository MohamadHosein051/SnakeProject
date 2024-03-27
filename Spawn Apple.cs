using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnApple : MonoBehaviour
{
    public GameObject FoodPrefab;
        public Transform BorderTop;
            public Transform BorderRight;
                public Transform BorderLeft;
                    public Transform BorderDown;
    void Start()
    {
        InvokeRepeating("Spawn",2,6);
    }
    void Spawn()
    {
        int x = (int)Random.Range(BorderLeft.position.x , BorderRight.position.x);
        int y = (int)Random.Range(BorderDown.position.y , BorderTop.position.y);
        Instantiate(FoodPrefab, new Vector3(x,y), Quaternion.identity);
    }
}
