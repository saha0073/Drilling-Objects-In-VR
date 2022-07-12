using System.Collections;
using System.Collections.Generic;
//using System.IO.Ports;
using UnityEngine;

public class Move : MonoBehaviour
{
    /*
    SerialPort sp = new SerialPort("COM7", 9600); // set port of your arduino connected to computer
    public Rigidbody rb;

    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1;
    }

    void Update()
    {
        if (sp.IsOpen)
        {
            try
            {
                //Debug.Log("sp "+sp.ReadByte());
                //Debug.Log("type " + sp.ReadByte().GetType());
                if (sp.ReadByte() == 1)
                {
                    //transform.Translate(Vector3.left * Time.deltaTime * 5);
                    //transform.Translate(Vector3.left * 50);
                    rb.AddRelativeForce(Vector3.left*5);
                    Debug.Log("sp " + sp.ReadByte());
                }
                if (sp.ReadByte() == 2)
                {
                    //transform.Translate(Vector3.right * Time.deltaTime * 5);
                    //transform.Translate(Vector3.right * 5);
                    rb.AddRelativeForce(Vector3.right);
                    Debug.Log("sp " + sp.ReadByte());
                }
            }
            catch (System.Exception)
            {
            }
        }
    }
    */
}
