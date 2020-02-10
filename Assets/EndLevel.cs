using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("End of level");
        Debug.Log("Il faut afficher le Menu de fin de niveau");
        Debug.Log("regarde l'Objet 'EndLevel' et son script 'EndLevel.cs' dans la fonction 'OnTriggerEnter'");
    }

}
