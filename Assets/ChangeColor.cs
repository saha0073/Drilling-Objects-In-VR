using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{

    [SerializeField] private GameObject cube;
    [SerializeField] Text desText;

    private Renderer cubeRenderer;
    private Color newCubeColor;
    private float randomChannelOne, randomChannelTwo, randomChannelThree;

    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer = cube.GetComponent<Renderer>();
        gameObject.GetComponent<Button>().onClick.AddListener(ChangeCubeColor);


        
    }

    private void ChangeCubeColor()
    {
        randomChannelOne = Random.Range(0f, 1f);
        randomChannelTwo = Random.Range(0f, 1f);
        randomChannelThree = Random.Range(0f, 1f);

        newCubeColor = new Color(randomChannelOne, randomChannelTwo, randomChannelThree, 1f);
        cubeRenderer.material.SetColor("_Color", newCubeColor);


        //Destroy(other.gameObject);
        //coins++;
        desText.text = "this button is pressed to rub the child on back";
        
        //  Debug.Log("Coins: " + coins);
        


    }

    
    
}
