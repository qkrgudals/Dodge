using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI recordText;
    //[SerializeField]
    public Button btn;

    private float surviveTime;
    private bool isGameover;
    
    
    public float SurviveTime {
        get => (int)surviveTime;
        set => surviveTime += value;
    }
   
    public bool IsGameover {
        get => isGameover;
    }
    
  
    void Start()
    {
        surviveTime = 0f;
        isGameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!isGameover) {
         surviveTime += Time.deltaTime;

            timeText.text = "Time: " + (int)surviveTime;    
        
        }
        else {
            if(Input.GetKeyDown(KeyCode.R)) {

                SceneManager.LoadScene("SampleScene");
            
            }
        }
    }
    public void EndGame() {
        isGameover=true;

        gameoverText.SetActive(true);
//btn.gameObject.SetActive(true);
        //recordText.gameObject.SetActive(true);
        
        float bestTime = PlayerPrefs.GetFloat("BestTime");

        if(surviveTime> bestTime) {
            bestTime = surviveTime;

            PlayerPrefs.SetFloat("BestTime", bestTime);
        }

        recordText.text = "Best Time: " + (int)bestTime;
    }
    public void Quit() {
        Application.Quit();
    }
}
