using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    
public class TriggerScript : MonoBehaviour
{

    public Text mtxt;

    public Text capsuleText;

    public Animation anim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Zapah")
        {
            Debug.Log("Zapah");
            StartCoroutine(ShowText("Вы почувствовали неприятный запах",mtxt));
            Destroy(other.gameObject);
        }
        else if(other.gameObject.tag == "kitchen")
        {
            Debug.Log("KITCHEN");
            StartCoroutine(ShowText("Это произошло в первый и последний раз",capsuleText));
            Destroy(other.gameObject);
        }
        else if(other.gameObject.tag == "sleep")
        {
            Debug.Log("SLLEP");
            StartCoroutine(ShowText("Просто вчера у малыша был праздник", capsuleText));
            Destroy(other.gameObject);
        }
        else if(other.gameObject.tag == "bathroom")
        {
            Debug.Log("bath");
        }
            
                
                //else if(other.gameObject.tag == "")
        //{
            
        //}
    }

    

    private IEnumerator ShowText(string text, Text txt)
    {
        string output = "";
        foreach (char c in text)
        {
            output += c;
            txt.text = output;
            yield return new WaitForSeconds(0.03f);
        }
        StartCoroutine(HideText(txt));
    }
    private IEnumerator HideText(Text txt)
    {
        yield return new WaitForSeconds(9f);
        txt.text = "";
    }
}
