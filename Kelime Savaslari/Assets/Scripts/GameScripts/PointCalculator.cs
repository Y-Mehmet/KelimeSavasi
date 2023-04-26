using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointCalculator : MonoBehaviour
{   public TextMeshProUGUI wordText;
    public int point=0;
    char[]  bir={'A','N','E','R','T','İ','K','L'};
    char[]  iki={'M','O','S','U','I'};
    char[]  uc={'B','D','Ü','Y'};
    char[] dort={'C','Ç','Ş','Z'};
    char[] bes={'G','P','H'};
    char[] yedi={'F','Ö','V'};
    char[] sekiz={'Ğ'};
    char[] on={'J'};
    char[] turkceBuyukHarfler = new char[] { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };
    Dictionary<char, int> charPoint = new Dictionary<char, int>();
    // Start is called before the first frame update
    void Start()
    {
manuelEkle(bir, 1);
manuelEkle(iki, 2);
manuelEkle(uc, 3);
manuelEkle(dort, 4);
manuelEkle(bes, 5);
manuelEkle(yedi, 7);
manuelEkle(sekiz, 8);
manuelEkle(on, 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    

void manuelEkle(char[] chars, int count)
{
    foreach (char c in chars)
    {
        charPoint[c] = count;
    }
}


    public void Point(string word)
    {
   
foreach (char c in word)
{ int value=0;

     
        if (charPoint.TryGetValue(c, out value))
{
    
    
     point+=value;
     print("point "+point);
}
}
        
    }
    public int GetPoint()
    {
        return point;
    }
}
