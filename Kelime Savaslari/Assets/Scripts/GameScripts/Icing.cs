using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Icing : MonoBehaviour
{
    public int sayac=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Latter"))
        {
            print("Yandım Yandım Ki ne yandım soğuktan yandımmm");
            other.gameObject.tag="Water";
            var colors =gameObject.GetComponentInChildren<Button> ().colors;
           colors.normalColor = Color.blue;
            other.gameObject.GetComponentInChildren<Button> ().colors = colors;
        }
        
    }
}
