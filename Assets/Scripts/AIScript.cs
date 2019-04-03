using UnityEngine.AI;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class AIScript : MonoBehaviour
{
    private NavMeshAgent navMesh;
    public Transform player;
    [SerializeField]
    private float maxDistance;
    public Text txt;

    private void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) > maxDistance)
        {
            navMesh.SetDestination(player.position - new Vector3(1f,0f,0f));
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "kitchen")
        {
            StartCoroutine(ShowText("Как вы видите, на кухне творится полный ужас - пьющие мужчины," +
            " огромно количество бутылок спиртных напитков,n с которыми играются дети, " +
            "наполненные шрамами от побоев. Это ужасно! "));
            Destroy(other);
        }
        else if(other.gameObject.tag == "bathroom")
        {
            StartCoroutine(ShowText("Текст про ванную"));
        }
        else if(other.gameObject.tag == "sleep")
        {
            StartCoroutine(ShowText("Sleep"));
        }
        
    }
    private IEnumerator ShowText(string text)
    {
        string output = "";
        foreach(char c in text)
        {
            output += c;
            txt.text = output;
            yield return new WaitForSeconds(0.03f);
        }
        StartCoroutine(HideText());
    }
    private IEnumerator HideText()
    {
        yield return new WaitForSeconds(9f);
        txt.text = "";
    }
}
