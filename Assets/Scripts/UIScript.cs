using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
    
public class UIScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Jumping();
    }
    
   public void Jumping()
    {
        transform.LeanMoveLocal(new Vector2(0, 150), 1).setEaseInOutQuart().setLoopPingPong();
    }
}
