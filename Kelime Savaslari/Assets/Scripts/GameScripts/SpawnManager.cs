using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnManager : MonoBehaviour
{
     public GameObject latter;
     public GameObject iceLatter;
     public GameObject bombLatter;
     public GameObject canvas;
     public string st = "BCÇDFGĞHJKLMNPRSŞTVYZ";
     public string sesli="AEIİOÖUÜ";
     int repeatTime=5;
     int i=1;
     GameObject ScoreMng;
    // Start is called before the first frame update
    void Start()

    {//GameObject.FindGameObjectWithTag("SpawnManager").
    //gameObject.transform.position;
    //GameObject.FindGameObjectWithTag("Canvas")
    ScoreMng=FindObjectOfType<GameManager>().gameObject;
    InvokeRepeating("SpawnLatter",1,repeatTime);
    FirstSpawn();
       
    
    }
    

    // Update is called once per frame
    void Update()
    { 
       if(ScoreMng.GetComponent<PointCalculator>().GetPoint()>i*100 && repeatTime>1)
       {
        i++;
        repeatTime--;
       }
    }
    void SpawnLatter()
    {
       if(!GameManager.isGameOver){
        if(Random.Range(0,9)==7)
        {
            float x=((Random.Range(0,8)*0.66f)-2.3f);
      //  print(x);
        Vector3 pos= new Vector3(x,2.55f,0);
       GameObject clone= Instantiate(iceLatter,pos,Quaternion.identity ,canvas.transform);
       string s=""+st[Random.Range(0,29)];
       clone.GetComponentInChildren<TextMeshProUGUI>().text=s;
        }else
        {
         float x=((Random.Range(0,8)*0.66f)-2.3f);
      //  print(x);
        Vector3 pos= new Vector3(x,2.55f,0);
       GameObject clone= Instantiate(latter,pos,Quaternion.identity ,canvas.transform);
       string s=""+st[Random.Range(0,29)];
       clone.GetComponentInChildren<TextMeshProUGUI>().text=s;
        }
       
       }
    }
    void FirstSpawn()
    {
        float xPos= -2.3f, yPos=-1;

        for (int i = 0; i < 24; i++)
        {
            if(i%8==0)
            {
                xPos=-2.3f;
                yPos+=1;
            }
            
            Vector3 pos= new Vector3(xPos,yPos,0);
            GameObject clone= Instantiate(latter,pos,Quaternion.identity ,canvas.transform);
            string s;
            if(Random.Range(0,3)==1)
            {
             s=""+st[Random.Range(0,sesli.Length)];   
            }else{
                s=""+st[Random.Range(0,st.Length)];
            }
            
            clone.GetComponentInChildren<TextMeshProUGUI>().text=s;
            xPos+=0.66f;
        }
    }
    public void LastSpawn(){
        float xPos= -2.3f, yPos=3;

        for (int i = 0; i < 8; i++)
        {
            
            
            Vector3 pos= new Vector3(xPos,yPos,0);
            GameObject clone= Instantiate(bombLatter,pos,Quaternion.identity ,canvas.transform);
            string s="";
            
            
            clone.GetComponentInChildren<TextMeshProUGUI>().text=s;
            xPos+=0.66f;
        }
    }
}
