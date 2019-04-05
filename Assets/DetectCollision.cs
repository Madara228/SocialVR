using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DetectCollision : MonoBehaviour
{
    public Text txt;

    

    private IEnumerator ShowText(string s)
    {
        string output = "";
        foreach(char c in s)
        {
            output += c;
            txt.text = output;
            yield return new WaitForSeconds(0.03f);
            StartCoroutine(HideText(txt));
        }
    }
    private IEnumerator HideText(Text _mtext)
    {
        yield return new WaitForSeconds(9f);
        _mtext.text = "";
    }
}
