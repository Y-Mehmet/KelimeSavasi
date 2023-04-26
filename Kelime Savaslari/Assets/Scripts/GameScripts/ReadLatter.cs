using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ReadLatter : MonoBehaviour
{
    // Start is called before the first frame update
    TextMeshProUGUI buttonText;
    public string letter="";
    public bool isClick=false;
    GameObject gmScript;
    TextMeshProUGUI wordText;
    static int  wordLength=0;
    public int sayac=0;
    // public List<GameObject> wordList= new List<GameObject>();
    
    //TMP_Text latter;

    void Start()
    {
        gmScript=GameObject.FindGameObjectWithTag("GM");
        buttonText= gameObject.GetComponentInChildren<TextMeshProUGUI>();
        wordText= GameObject.FindGameObjectWithTag("Word").GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
       if(transform.position.y>2.7f && !GameManager.isGameOver )
       {
      //  print("oyun bitajjjj");
        FindObjectOfType<GameManager>().GameOver();
       }
       if(GameManager.isClickDelete && isClick)
       {
        
        if( wordLength>=gmScript.GetComponent<GameManager>().wordList.Count-1)
        {
            
            GameManager.isClickDelete=false;
            isClick=false;
            wordLength++;
            
            gmScript.GetComponent<GameManager>().wordList.RemoveRange(0,gmScript.GetComponent<GameManager>().wordList.Count);
            wordLength=0;
            print(wordLength+" sayac son uzunluk,  butonlar sifirlandiktan sonraki wordlist count"+gmScript.GetComponent<GameManager>().wordList.Count);
        }
        else{
            wordLength++;
            print(wordLength+"sayac");
            print(gmScript.GetComponent<GameManager>().wordList.Count+" bu da wordlist uzunluk");
            isClick=false;

        }
        
       }
       if(GameManager.iceBeCleaned && isClick )
       {
        
        if(gameObject.transform.parent.CompareTag("IceLatter") || gameObject.transform.parent.CompareTag("Water"))
        {
           isClick=false; 
           gmScript.GetComponent<GameManager>().iceCount--;
        }
        if(gmScript.GetComponent<GameManager>().iceCount==0)
        GameManager.iceBeCleaned=false;

       }
       
    }
   public void Reading(){
    if(!isClick)
    {
    letter=buttonText.text;
    
    //Debug.Log("harf:"+buttonText.text);
    gmScript.GetComponent<GameManager>().word+=letter;
   // Debug.Log("harf:"+gmScript.GetComponent<GameManager>().word);
    wordText.text=gmScript.GetComponent<GameManager>().word;
    gmScript.GetComponent<GameManager>().wordList.Add(gameObject);
    
    isClick=true;
    }else

    {   string temp="",temp2="";
    

        temp= gmScript.GetComponent<GameManager>().word;
        if(temp.Length>0)
        {
            temp2= temp.Substring(0,temp.Length-1);
        }
        else{
            temp2="";
        }
        print(temp2);
        gmScript.GetComponent<GameManager>().word=temp2;
        wordText.text=gmScript.GetComponent<GameManager>().word;
        if(gmScript.GetComponent<GameManager>().wordList.Count>0)
        gmScript.GetComponent<GameManager>().wordList.RemoveAt(gmScript.GetComponent<GameManager>().wordList.Count-1);
       
        isClick=false;
    }
    
    }
    void ButtonResetting(){
        wordLength++;
    }
    void IceLatterMethod(){

    }
    
    
    
   
    
    
}
