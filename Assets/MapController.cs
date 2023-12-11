using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    public TextAsset txtMap;
    public string[] arrayMap;
    public string[] arrayRowMap;
    // Start is called before the first frame update
    void Start()
    {
        arrayMap = txtMap.text.Split("\n");
        for (int i = 0; i < arrayMap.Length; i++)
        {
            arrayRowMap = arrayMap[i].Split(";");
            for (int j = 0; j< arrayRowMap.Length; i++)
            {
                if (arrayRowMap[j] == "4")
                {

                }
                else if (arrayRowMap[i] == "8")
                {
                    
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
