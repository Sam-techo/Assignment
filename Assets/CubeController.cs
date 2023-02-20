using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] List<int> numbers;
    bool isDone = true;
    bool isRemoved = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (isDone)
        {
            for (int i = 0; i < numbers.Count; i++)
            {

                for (int j = 0; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j] && j != i)
                    {
                        Debug.Log("found duplicate: " + numbers[j]);
                        numbers.RemoveAt(numbers[j]);
                        isRemoved = true;

                    }
                    else
                    {
                        isRemoved = false;
                    }
                }
                if (isRemoved) {
                    i = 0;
                }


            }

            Debug.Log("All duplicates are Removed");
            isDone = false;
        }

        
    }


}
