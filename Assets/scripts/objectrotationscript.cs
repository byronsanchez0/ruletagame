using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class objectrotationscript : MonoBehaviour
{
    private int randomValue;
    private float timeInterval;
    private bool coroutineAllowed;
    private int finalAngle;

    [SerializeField]
    private TMP_Text winText;

    private void Start()
    {
        coroutineAllowed = true;
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            StartCoroutine(Spin());
            Debug.Log("aver aver");
        }
    }

    private IEnumerator Spin ()
    {
        coroutineAllowed = false;
        randomValue = Random.Range(20, 80);
        timeInterval = 0.03f;

        for(int i= 0; i< randomValue; i++)
        {
            transform.Rotate(0, 0, -15f);
           
            if (i> Mathf.RoundToInt(randomValue *0.5f))
                timeInterval = 0.05f;
            if (i > Mathf.RoundToInt(randomValue * 0.5f))
                timeInterval = 0.05f;
            if (i > Mathf.RoundToInt(randomValue * 0.5f))
                timeInterval = 0.05f;
            if (i > Mathf.RoundToInt(randomValue * 0.5f))
                timeInterval = 0.05f;
            if (i > Mathf.RoundToInt(randomValue * 0.85f))
                timeInterval = 0.1f;
            if (i > Mathf.RoundToInt(randomValue * 0.88f))
                timeInterval = 0.13f;
            if (i > Mathf.RoundToInt(randomValue * 0.9f))
                timeInterval = 0.15f;
            if (i > Mathf.RoundToInt(randomValue * 0.93f))
                timeInterval = 0.16f;
            yield return new WaitForSeconds(timeInterval);
        }

        if(Mathf.RoundToInt(transform.eulerAngles.z) % -90 != 0)
        {
            transform.Rotate(0, 0, -15f);
        }

        
        finalAngle = Mathf.RoundToInt(transform.eulerAngles.z);

       if(finalAngle > 180)
        {
            finalAngle -= 360;
        }

        switch (finalAngle)
        {
            case 0:
                winText.text = "GIRALA OTRA VEZ";
                break;
            case 40:
                winText.text = "DINAMICA 1";
                break;
            case 80:
                winText.text = "DINAMICA 2";
                break;
            case 120:
                winText.text = "DINAMICA 3";
                break;
            case 160:
                winText.text = "DINAMICA 4";
                break;
            case -160:
                winText.text = "DINAMICA 5";
                break;
            case -120:
                winText.text = "DINAMICA 6";
                break;
            case -80:
                winText.text = "DINAMICA 7";
                break;
            case -40:
                winText.text = "DINAMICA 8";
                break;

        }
        coroutineAllowed = true;

    }
}

//private IEnumerator Spin()
//{
//    coroutineAllowed = false;
//    randomValue = Random.Range(20, 30);
//    timeInterval = 0.07f;

//    for (int i = 0; i < randomValue; i++)
//    {
//        transform.Rotate(0, 0, 40f);
//        if (i > Mathf.RoundToInt(randomValue * 0.3f))
//            timeInterval = 0.1f;
//        if (i > Mathf.RoundToInt(randomValue * 0.5f))
//            timeInterval = 0.2f;
//        if (i > Mathf.RoundToInt(randomValue * 0.85f))
//            timeInterval = 0.4f;
//        yield return new WaitForSeconds(timeInterval);
//    }

//    if (Mathf.RoundToInt(transform.eulerAngles.z) % 90 != 0)
//    {
//        transform.Rotate(0, 0, 40f);
//    }

//    finalAngle = Mathf.RoundToInt(transform.eulerAngles.z);