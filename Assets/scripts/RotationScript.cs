using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    int randVal;
    private float timeInterval;
    private bool isCourutine;
    private int finalAngle;

    public TMP_Text winText;
    public int section;
    float totalAngle;
    public string[] Prizename;
    void Start()
    {
        isCourutine = false;
        totalAngle = 360 / section;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isCourutine)
        {
            StartCoroutine(Spin());
        }
    }

    private IEnumerator Spin()
    {
        isCourutine = false;
        randVal = Random.Range(200, 300);
        timeInterval = 0.0001f * Time.deltaTime * 2;

        for (int i = 0; i < randVal; i++)
        {
            transform.Rotate(0, 0, (totalAngle / 2));


            //To SlowDown wheel
            if (i > Mathf.RoundToInt(randVal * 0.2f))
                timeInterval = 0.5f * Time.deltaTime;
            if (i > Mathf.RoundToInt(randVal * 0.5f))
                timeInterval = 1f * Time.deltaTime;
            if (i > Mathf.RoundToInt(randVal * 0.7f))
                timeInterval = 1.5f * Time.deltaTime;
            if (i > Mathf.RoundToInt(randVal * 0.8f))
                timeInterval = 2f * Time.deltaTime;
            if (i > Mathf.RoundToInt(randVal * 0.9f))
                timeInterval = 2.5f * Time.deltaTime;

            yield return new WaitForSeconds(timeInterval);
        }

        if (Mathf.RoundToInt(transform.eulerAngles.z) % totalAngle != 0)
            transform.Rotate(0, 0, totalAngle / 2);

        finalAngle = Mathf.RoundToInt(transform.eulerAngles.z);

        print(finalAngle);

        for (int i = 0; i < section; i++)
        {
            if (finalAngle == i * totalAngle)
            {
                winText.text = Prizename[i];
            }
        }

        isCourutine = true;
    }
}
