using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int points;
    
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Q))
        {
            points = 50; 
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            points = 100;
        }
       else if (Input.GetKeyDown(KeyCode.E))
        {
            points = 0;
        }

      
       switch(points)
        {
            case 50:
                Debug.Log("Points are 50!");
                break;

            case 100:
                Debug.Log("Points are 100!");
                break;

            default:
                Debug.Log("You need 50 or 100 points to receive a message");
                break;
        }
    }
}
