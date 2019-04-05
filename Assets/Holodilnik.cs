using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holodilnik : MonoBehaviour
{

    public GameObject door;
    public GameObject door1;



    public void playAnim()
    {
        door.transform.localRotation = Quaternion.Euler(-90, door.transform.rotation.y, -90); 
    }
    public void RotateDoor()
    {
            //door1.transform.localRotation = Quaternion.Euler(-90, 0, 180);
       
    }
}
