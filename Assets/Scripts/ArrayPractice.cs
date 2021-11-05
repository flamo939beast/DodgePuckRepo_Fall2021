using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    public int[] LottoNumbers = { 1, 2, 3, 4, 5, 6 };
    public int myNumber;
    // Start is called before the first frame update
    void Start()
    {
        myNumber = LottoNumbers[Random.Range(0, 5)];
        Debug.Log("my lotto number is" + myNumber);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
