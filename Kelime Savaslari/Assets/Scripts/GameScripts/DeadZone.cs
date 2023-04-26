using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeadZone : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("IceLatter"))
        {
           // print("Yandım Yandım Ki ne yandım soğuktan yandımmm");
            var colors =other.gameObject.GetComponentInChildren<Button> ().colors;
           colors.normalColor = Color.blue;
            gameObject.GetComponentInChildren<Button> ().colors = colors;
        }
        
    }
}
