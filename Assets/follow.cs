using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{

    [SerializeField] Transform mTarget;
    float mSpeed = 10.0f;
    const float EPSILON = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        transform.LookAt(mTarget);
        if ((transform.position-mTarget.position).magnitude > EPSILON){
            transform.Translate(0.0f, 0.0f, mSpeed * Time.deltaTime);
        }
        */
        gameObject.transform.position = new Vector3(-1.84f, -0.757f, 2.09f);
        //transform.position = new Vector3(-1.84f, -0.757f, 2.09f);
        
    }
}
