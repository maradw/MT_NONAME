using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    public GameObject lifePrefab;
    public int quantityLifes;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i< quantityLifes; i++)
        {
            GameObject temp =Instantiate(lifePrefab, transform.position, transform.rotation);
            temp.transform.SetParent(this.gameObject.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
