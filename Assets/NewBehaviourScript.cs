using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{  
    Vector3 POintA = new Vector3(0, 0, 100);
 Vector3 POintB = new Vector3(0, 0, 0);
 Vector3 POintC = new Vector3(0, 0, 50);
float P = 0.0f;
public  float  speed1= 20.0f;
public float waitTime = 0.0f;
 int dir =-1;
 bool isWaiting = false;
 float waitingtime = 0f;
    void Start()
    {
        print("开始");
        transform.position = new Vector3(0, 0, 0);
    }
  
    // FixedUpdate is called once per fixed frame
    void Update()
    {if(isWaiting)
        {
waitingtime -=Time.deltaTime;
if(waitingtime <= 0)
            {
                isWaiting = false;
            }
        }

float dict = Vector3.Distance(POintA, POintB);
      
float speed =speed1*(1+ 9*(Vector3.Distance(POintC, transform.position)/50));
  P += dir * speed * Time.deltaTime / dict;
if(P >= 1.0)
        {
            P=1.0f;
            dir= -1;
            isWaiting = true;
            waitingtime = waitTime; 
        }
        else if(P <= 0.0)
        {
            P = 0.0f;
            dir = 1;
                        isWaiting = true;
            waitingtime = waitTime;
        }
        transform.position = Vector3.Lerp(POintA, POintB, (float)P);
    }
}
