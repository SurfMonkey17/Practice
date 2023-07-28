using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject cube;

    private int _nextColor;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _nextColor = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _nextColor = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _nextColor = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _nextColor = 3;
        }
       
       switch(_nextColor) {
            //key 1 = blue
            case 0:
                cube.GetComponent<Renderer>().material.color = Color.blue;
                break;

            //key 2 = red
            case 1:
                cube.GetComponent<Renderer>().material.color = Color.red;
                break;

            //key 3 = green
            case 2:
                cube.GetComponent<Renderer>().material.color = Color.green;
                break;

            //key 4 = black:
            case 3:
                cube.GetComponent<Renderer>().material.color = Color.black;
                break;

            default:
                Debug.Log("Invalid selection");
                break;
        }
    }
}
