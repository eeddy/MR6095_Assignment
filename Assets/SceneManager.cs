using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Utilities;

public class SceneManager : MonoBehaviour
{
    public GameObject template;
    public GameObject plant, painting, book, pillow, chair, sofa, table, lamp;
    private GameObject currentObject;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Here!");
    }

    public void HousePlantClicked() {
        Debug.Log("House Plant");
        CreateObject(plant, new Vector3(0.1f, 0.1f, 0.1f));
    }

    public void HousePaintingClicked() {
        Debug.Log("Painting");
        CreateObject(painting, new Vector3(1,1,1));
    }

    public void BooksClicked() {
        Debug.Log("Books");
        CreateObject(book, new Vector3(1,1,1));
    }

    public void PillowClicked() {
        Debug.Log("Pillow");
        CreateObject(pillow, new Vector3(1,1,1));
    }

    public void ChairClicked() {
        Debug.Log("Chair");
        CreateObject(chair, new Vector3(1,1,1));
    }

    public void SofaClicked() {
        Debug.Log("Sofa");
        CreateObject(sofa, new Vector3(1,1,1));
    }

    public void TableClicked() {
        Debug.Log("Table");
        CreateObject(table, new Vector3(1,1,1));
    }

    public void LampClicked() {
        Debug.Log("Lamp");
        CreateObject(lamp, new Vector3(1,1,1));
    }

    public void DefaultColour() {
        currentObject.GetComponent<Renderer> ().material.color = Color.white;
    }

    public void Red() {
        if(currentObject != null){
            currentObject.GetComponent<Renderer> ().material.color = Color.red;
        }
    }

    public void Green() {
        if(currentObject != null){
            currentObject.GetComponent<Renderer> ().material.color = Color.green;
        }
    }

    public void Blue() {
        if(currentObject != null){
            currentObject.GetComponent<Renderer> ().material.color = Color.blue;
        }
    }

    public void Magenta() {
        if(currentObject != null){
            currentObject.GetComponent<Renderer> ().material.color = Color.magenta;
        }
    }

    public void Cyan() {
        if(currentObject != null){
            currentObject.GetComponent<Renderer> ().material.color = Color.cyan;
        }
    }

    public void Yellow() {
        if(currentObject != null){
            currentObject.GetComponent<Renderer> ().material.color = Color.yellow;
        }
    }

    public void Black() {
        if(currentObject != null){
            currentObject.GetComponent<Renderer> ().material.color = Color.black;
        }
    }

    void CreateObject(GameObject obj, Vector3 vec) {

        if(currentObject != null) {
            Destroy(currentObject);
        }

        GameObject nObj = GameObject.Instantiate(obj,new Vector3(0,0.2f,0),Quaternion.identity);
        nObj.transform.localScale = vec;
        nObj.AddComponent<BoxCollider>();
        nObj.AddComponent<ObjectManipulator>();
        currentObject = nObj;

    }
}
