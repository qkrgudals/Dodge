using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TimeTextDisplay : MonoBehaviour
{
    GameManager gameManager;
    TextMeshProUGUI timeText;
    // Start is called before the first frame update
    void Start()
    {
        timeText = GetComponent<TextMeshProUGUI>();
       gameManager=FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameManager.IsGameover) {
            gameManager.SurviveTime = Time.deltaTime;
            int scoreTime=(int)gameManager.SurviveTime;
            timeText.text="Time: "+scoreTime.ToString();
        }
    }
    
}
