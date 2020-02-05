using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveDoor : MonoBehaviour
{
    public bool asHisKey = false;
    public bool isActivate = false;
    public GameObject rightDoor;
    public GameObject leftDoor;
    public Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
        //  anim.Play("movingPlatform");
    }


    void Update()
    {
        if (this.transform.position.y <= -0.3)
        {
            isActivate = true;
        }
        if (isActivate)
        {
            Debug.Log(rightDoor.transform.localPosition.z);
            if (leftDoor.transform.localPosition.x < 2.3)
                leftDoor.transform.localPosition += transform.right * Time.deltaTime;
            if (rightDoor.transform.localPosition.z < 9.3)
                rightDoor.transform.localPosition -= transform.up * Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
            asHisKey = true;
            MoveDown();
        }
        else
        {
            asHisKey = false;
            MoveUp();
        }
    }

    void MoveDown()
    {
        if (asHisKey && !isActivate)
        {
            Debug.Log("Moving Down");
            transform.position -= transform.up * Time.deltaTime;
        }
    }
    void MoveUp()
    {
        if (!asHisKey && this.transform.position.y < 0.2)
        {
            Debug.Log("Moving Up");
            transform.position += transform.up * Time.deltaTime;
        }
    }
}
