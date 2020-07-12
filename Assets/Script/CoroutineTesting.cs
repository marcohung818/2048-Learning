using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTesting : MonoBehaviour
{
    int coroutineCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        //TheMethod();

        StartCoroutine (TheCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void TheMethod()
    {
        int i = 0;
        while (i < 20)
        {
            print("Method Says" + i.ToString());
            i++;
        }
    }

    IEnumerator TheCoroutine()
    {
        while (true)
        {
            print("Coroutine says" + coroutineCounter.ToString());
            coroutineCounter++;
            yield return new WaitForSeconds(1f);
        }
    }
}
