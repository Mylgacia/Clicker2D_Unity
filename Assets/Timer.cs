using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text timerText;

    private float timeElapsed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        timerText.text = timeElapsed.ToString("0:05");
        //timerText.text = string.Format("00:00");

        if (timerText.text == "0:05")
        {
            Debug.Log("Loose");

            Time.timeScale = 0;
            Destroy(this);
        }
    }
}
