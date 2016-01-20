using UnityEngine;
using System.Collections;

public class AIcontrols : MonoBehaviour
{
    public float enemyMoveSpeed = 0f;
    public float walkDistance = 0f;
    public bool move = false;
    private int timer = 0;
    Vector3 walkAmt;
    Vector3 defaultPos;
    private bool flipped = false;
    // Use this for initialization
    void Start()
    {
        defaultPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {  
        
        
        Vector3 currPos = transform.position;
        float maxPos = defaultPos.x + .5f * walkDistance;
        float minPos = defaultPos.x - .5f * walkDistance;
        
        if (currPos.x < maxPos && currPos.x > minPos)
        {
            
            move = true;
            if(!flipped)
            {
                walkAmt.x = -enemyMoveSpeed * Time.deltaTime;
                transform.Translate(walkAmt);
            }
            else
            {
                walkAmt.x = enemyMoveSpeed * Time.deltaTime;
                transform.Translate(walkAmt);
            }
            
        }
        else
        {
            walkAmt.x = 0;
            move = false;
        }

        if (move == true)
        {
            timer = 0;
        }
        else
        {
            timer += 1;
            
            if (timer == 100)
            {
                print("hello");
                Vector3 theScale = transform.localScale;
                theScale.x *= -1;
                transform.localScale = theScale;
                if (!flipped)
                {
                    walkAmt.x = enemyMoveSpeed * Time.deltaTime;
                }
                else
                {
                    walkAmt.x = -enemyMoveSpeed * Time.deltaTime;
                } 

                transform.Translate(walkAmt);

                flipped = !flipped;
                move = true;
            }
        }
        
    }
}
