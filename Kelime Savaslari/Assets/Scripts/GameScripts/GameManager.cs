using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
    ReadLatter readLatterScript;
    public string word="";
    public TextMeshProUGUI wordText;
    public TextMeshProUGUI pointText;
    public bool isSearch=false;
    public static bool isGameOver=false;
    public bool isThereAWord=false;
    public static bool isClickDelete= false;
    public List<GameObject> wordList= new List<GameObject>();
    public static bool iceBeCleaned=false;
    public  int iceCount=0;
    int[] maxPoints= new int[6];
    int [] tempA= new int[5];
    int wrongCount=0;
    // GameObject readerLatter;
    // Start is called before the first frame update
    void Start()
    {
    // readerLatter= GameObject.FindGameObjectWithTag("ReaderLatter");
    gameObject.GetComponent<TextReader>().Reading();
    isGameOver=false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            if (touchDeltaPosition.x > 0) // Ekran sağa kaydırıldığında
            {
                ClickSearchButton();
            }
        }

        if(isSearch )
        {
           if( gameObject.GetComponent<TextReader>().WordSearch(word) )
           {
           
               
                gameObject.GetComponent<PointCalculator>().Point(word);
                pointText.text="Puan: "+gameObject.GetComponent<PointCalculator>().GetPoint();
                
                word="";
                wordText.text=word;
           
            // buraya destroy metodu gelcek
            
                SearchResaultTrue();
            
            
            
            
            isThereAWord=true;
            isSearch=false;
           }
           else{
            Debug.Log("Kelime bulunamadi"+word);
          /*  word="";
            wordText.text=word;*/
            ClickDeleteButton();
           // SearchResaultFalse();
           if(wrongCount<2)
        {
            wrongCount++;
        }
        else
        {
            GameOver();
        }
            isSearch= false;
            isThereAWord=false;
            
           }
        }
        foreach (var item in wordList)
        {
            if(item.gameObject.transform.parent.gameObject.CompareTag("IceLatter") || item.gameObject.transform.parent.gameObject.CompareTag("Water"))
            {
                iceCount++;
            }
        }
    }
  /*  public bool WordSearch(string word){
        if(string.Compare(word,"ALİ")==0)
        {
            return true;
        }
        else{
            return false;
        }
        //return true;
       
    }*/
    public void ClickSearchButton()
    {
        isSearch=true;
        isThereAWord=false;
    }
    public void ClickDeleteButton()
    {
        isClickDelete=true;
        word="";
        wordText.text=word;
    }
    public void GameOver(){
        wrongCount=0;
        isGameOver=true;
       isMaxPoint();
       GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManager>().LastSpawn();
       
        
    }
    void isMaxPoint()
    { 
    /* if(PointMemory.getMaxScore()<1)
     {
        PointMemory.setMaxScore(0);
     }if(PointMemory.get2MaxScore()<1)
     {
        PointMemory.set2MaxScore(0);
     } if(PointMemory.get3MaxScore()<1)
     {
        PointMemory.set3MaxScore(0);
     } if(PointMemory.get4MaxScore()<1)
     {
        PointMemory.set4MaxScore(0);
     } if(PointMemory.get5MaxScore()<1)
     {
        PointMemory.set5MaxScore(0);
     }

      int point = gameObject.GetComponent<PointCalculator>().GetPoint();
        maxPoints[0]=point;
        maxPoints[1]=PointMemory.getMaxScore();
        maxPoints[2]=PointMemory.get2MaxScore();
        maxPoints[3]=PointMemory.get3MaxScore();
        maxPoints[4]=PointMemory.get4MaxScore();
        maxPoints[5]=PointMemory.get5MaxScore();
        for (int i = 0; i < 5; i++)
       {
        
       
        print(maxPoints[i]+ " inci point*** "+i);
        
        
       }
        Array.Sort(maxPoints);
       Array.Reverse(maxPoints);
       for (int i = 0; i < 5; i++)
       {
        
       
        print(maxPoints[i]+ " inci point "+i);
        
        
       }
         PointMemory.setMaxScore(maxPoints[0]);
          PointMemory.set2MaxScore(maxPoints[1]);
           PointMemory.set3MaxScore(maxPoints[2]);
            PointMemory.set4MaxScore(maxPoints[3]);
             PointMemory.set5MaxScore(maxPoints[4]);

        

      */ int point = gameObject.GetComponent<PointCalculator>().GetPoint();
         if(PointMemory.hasMaxScore())
        {
            print("en yüksek score daha önce kaydedilmiş");
        int maxPoint= (PointMemory.getMaxScore());
          if(point>=maxPoint)
          { int temp=PointMemory.getMaxScore();
          //int temp2= PointMemory.get2MaxScore();
            PointMemory.setMaxScore(point);
            PointMemory.set2MaxScore(temp);
            //PointMemory.set3MaxScore(temp2);
            print("max score güncellendi");
           
          }
          else if(PointMemory.has2MaxScore())
          {
            if(point>=PointMemory.get2MaxScore())
          {
            int temp=PointMemory.get2MaxScore();
          //int temp2= PointMemory.get2MaxScore();
            PointMemory.set2MaxScore(point);
            PointMemory.set3MaxScore(temp);
            //PointMemory.set3MaxScore(temp2);
            print("max2 score güncellendi");
          }
           else if(PointMemory.has3MaxScore())
          {
            if(point>=PointMemory.get3MaxScore())
          {
            
            PointMemory.set3MaxScore(point);
            //PointMemory.set3MaxScore(temp2);
            print("max3 score güncellendi");
          }
          }
          else{
            PointMemory.set3MaxScore(point);
          }
          }
          else{
            PointMemory.set2MaxScore(point);
            PointMemory.set3MaxScore(0); 
          }
          
         
        }
         else{
            print("ilk defa maz score ekledni");
           PointMemory.setMaxScore(point); 
           PointMemory.set2MaxScore(0); 
           PointMemory.set3MaxScore(0); 
           
        }
        /*else if(PointMemory.has2MaxScore())
        {
            if(point>PointMemory.get2MaxScore())
        {
            int temp=PointMemory.getMaxScore();
          int temp2= PointMemory.get2MaxScore();
            PointMemory.set2MaxScore(point);
            PointMemory.set3MaxScore(temp);
            PointMemory.set4MaxScore(temp2);
            print("max score güncellendi");
        }
        }
        else if(point>PointMemory.get2MaxScore())
        {
            int temp=PointMemory.getMaxScore();
          int temp2= PointMemory.get2MaxScore();
            PointMemory.set2MaxScore(point);
            PointMemory.set3MaxScore(temp);
            PointMemory.set4MaxScore(temp2);
            print("max score güncellendi");
        }*/
       
    }
    void SearchResaultTrue()
    {
        // print( "kelime aramasi sonucu true");
           
            for (int i = 0; i < wordList.Count; i++)
            {   if(wordList[i].gameObject.transform.parent.gameObject.CompareTag("IceLatter") || wordList[i].gameObject.transform.parent.gameObject.CompareTag("Water") )
            {
                if(wordList[i].gameObject.GetComponent<ReadLatter>().sayac>1)
                {
                Destroy(wordList[i].gameObject.transform.parent.gameObject);
                print("kelime silindi");
                }
                else{
                     wordList[i].gameObject.GetComponent<ReadLatter>().sayac++;
                iceBeCleaned=true;
                 print("buzlu kelime sayac artırıldı sayac:"+wordList[i].gameObject.GetComponent<ReadLatter>().sayac);
                }
                wordList[i].gameObject.GetComponent<ReadLatter>().sayac++;
                iceBeCleaned=true;
                print("buzlu kelime silinmedi sayac: "+wordList[i].gameObject.GetComponent<ReadLatter>().sayac);
            }
            else{
                Destroy(wordList[i].gameObject.transform.parent.gameObject);
                print("kelime silindi");
            }
          //  if(wordList[i].gameObject.GetComponent<Button>().colors)
            /*Destroy(wordList[i].gameObject.transform.parent.gameObject);
                print("kelime silindi");*/
                
            }
            
            wordList.RemoveRange(0,wordList.Count);
            print("wordlist count"+wordList.Count);
        
        
    }
    void SearchResaultFalse(){
        if(wrongCount<2)
        {
            wrongCount++;
        }
        else
        {
            GameOver();
        }
        
          //  print("kelme bulunamadi ");
            wordList.RemoveRange(0,wordList.Count);
            print("kelime yok wordlist count"+wordList.Count);
        
    }
    public void Restart()
    {
        isGameOver=false;
        wrongCount=0;
    }
 
    
}
