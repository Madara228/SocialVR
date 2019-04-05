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
            navMesh.SetDestination(player.position - new Vector3(0f,0f,2f));
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
