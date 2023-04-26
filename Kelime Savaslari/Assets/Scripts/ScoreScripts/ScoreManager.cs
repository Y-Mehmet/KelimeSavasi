using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI maxScore1;
    public TextMeshProUGUI maxScore2;
    public TextMeshProUGUI maxScore3;
   // public TextMeshProUGUI maxScore4;
   // public TextMeshProUGUI maxScore5;
    
    // Start is called before the first frame update
    void Start()
    {
         maxScore1.text= "1-) "+PointMemory.getMaxScore();
         maxScore2.text= "2-) "+PointMemory.get2MaxScore();
         maxScore3.text= "3-) "+PointMemory.get3MaxScore();
       //  maxScore4.text= "4-) "+PointMemory.get4MaxScore();
       //  maxScore5.text= "5-) "+PointMemory.get5MaxScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SaveNewMaxScore()
    {
       
            }
    public void ChangeSceen(){
        SceneManager.LoadScene("Menu");
    }
}
