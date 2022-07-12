using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visible : MonoBehaviour
{
    public float sec = 14f;
    //public MyController MyController;

    Rigidbody rb;
    public float forceValue = 100f;

    // Start is called before the first frame update
    void Start()
    {
        //MyController.StartCoroutine(LateCall(sec));
        rb = GetComponent<Rigidbody>();
    }
    /*
    IEnumerator LateCall(float seconds)
    {
        if (gameObject.activeInHierarchy)
            gameObject.SetActive(false);

        yield return new WaitForSeconds(seconds);

        gameObject.SetActive(true);
        //Do Function here...
    }
    */
    void Update()
    {

        if (Input.GetKeyDown("w"))
        {
            rb.AddForce(Vector3.up * forceValue);
        }
        /*if (transform.position.y > 1.25f || transform.position.y < -1.25f)
        {
            GameManager.isPlaying = false;
        }*/
        if (Input.GetKeyDown("s"))
        {
            rb.AddForce(Vector3.down * forceValue);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggered");
        
        if (other.gameObject.CompareTag("Plane"))
        //if (other.TryGetComponent<Wall>(out Wall wall))
        {
            
            Debug.Log("hit plane");
            transform.position = Vector3.zero;
            rb.velocity = new Vector3(0, 0, 0);

        }

    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("entered collision");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("staying collision");

    }
}
