using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class TextReader : MonoBehaviour
{
    public List<string> kelimeler= new List<string>();
    bool searchResault=false;
    string[] words;
    int sayac=0;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Reading()
    {
        print("text reading sınıfı çalıştı");
        string line;
        

    //Pass the file path and file name to the StreamReader constructor
    StreamReader sr = new StreamReader("C:\\Kelimeler\\A.txt");
    //Read the first line of text
    line = sr.ReadLine();
    
    //Continue to read until you reach end of file
    while (line != null)
    {
        //write the line to console window
       // Console.WriteLine(line);
        //Read the next line
     //   words = line.Split(' ');
     kelimeler.Add(line);
     line= sr.ReadLine();
            /* for (int i = 0; i < line.Length; i++)
             {
                 if(words[0]==' ')
             {
                 kelimeler.Add(line);
                 print("kelimemiz*******"+line);
                 line="";
                 line = sr.ReadLine();
             }
             else
             {
                 line = sr.ReadLine();
             }

             }*/

        }
    //close the file
    sr.Close();
    
   // print(line);
   // Console.ReadLine();
    }
     public bool WordSearch(string word){

       /*for (int i = 0; i < kelimeler.Count; i++)
        {
            if(string.Compare(word,"ALİ")==0)
        {   
            searchResault=true;
            return searchResault;
        }
        else{
            searchResault=false;
            return searchResault;
        }
        }*/
        foreach (var item in kelimeler)
        {
          if(word==item)
        {   print(word+" eşittir "+item);
            searchResault=true;
            return searchResault;
        }
        else{
           // print(word+" eşittir değildir "+item);
            searchResault=false;
            
        }  
        }
        
        return searchResault;
       
    }

}
