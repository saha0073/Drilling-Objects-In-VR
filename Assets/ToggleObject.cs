using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleObject : MonoBehaviour
{

    [SerializeField] private GameObject cube;
    [SerializeField] private GameObject sphere;
    [SerializeField] Text desText;

    // Start is called before the first frame update
    void Start()
    {
        
        gameObject.GetComponent<Button>().onClick.AddListener(ToggleVisibility);



    }

    private void ToggleVisibility()
    {
        StartCoroutine(RemoveAfterSeconds(5));
        


    }
    IEnumerator RemoveAfterSeconds(int seconds)
    {
        Renderer cubeRenderer = cube.GetComponent<Renderer>();
        Renderer sphereRenderer = sphere.GetComponent<Renderer>();


        cubeRenderer.enabled = true;
        desText.text = "this button is pressed to rub on the back";
        yield return new WaitForSeconds(seconds);
        cubeRenderer.enabled = false;

        sphereRenderer.enabled = true;
        desText.text = "this button is pressed to tap on the belly";
        yield return new WaitForSeconds(seconds);
        sphereRenderer.enabled = false;




    }
    /*
    private void ToggleVisibility()
    {
        Renderer cubeRenderer = cube.GetComponent<Renderer>();
        Renderer sphereRenderer = sphere.GetComponent<Renderer>();

        

        //StartCoroutine(RemoveAfterSeconds(5, cubeRenderer, desText, "this button is pressed to rub on the back"));
        StartCoroutine(RemoveAfterSeconds(5, sphereRenderer, desText, "this button is pressed to tap on the belly"));

        //yield return new WaitForSeconds(14);
        //FunctionTimer.Create(() => (cubeRenderer.enabled = false), 0.1f);
        //cubeRenderer.enabled = false;

    }
    IEnumerator RemoveAfterSeconds(int seconds, Renderer rend, Text desText, string txtstr)
    {
        rend.enabled = true;
        desText.text = txtstr;
        yield return new WaitForSeconds(seconds);
        rend.enabled = false;
        yield return new WaitForSeconds(seconds);
        rend.enabled = true;

    }
    */
}
