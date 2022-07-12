using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{

    //[SerializeField] Color newCubeColor;
    //[SerializeField] Color 
    // Start is called before the first frame update
    [SerializeField] private GameObject cube;
    private Renderer cubeRenderer;
    private float randomChannelOne, randomChannelTwo, randomChannelThree;
    private Color newCubeColor;
    void Start()
    {
        cubeRenderer = cube.GetComponent<Renderer>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collided");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("collideobject"))
        {
            Debug.Log("collided");
            randomChannelOne = Random.Range(0f, 1f);
            randomChannelTwo = Random.Range(0f, 1f);
            randomChannelThree = Random.Range(0f, 1f);
            newCubeColor = new Color(randomChannelOne, randomChannelTwo, randomChannelThree, 1f);

            cubeRenderer.material.SetColor("_Color", newCubeColor);

        }
            




    }
}
