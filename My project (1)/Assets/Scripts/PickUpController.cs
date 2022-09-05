using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour
<<<<<<< HEAD
{
    [Header("Pickup Settings")]
    [SerializeField] Transform holdArea;
    private GameObject heldObj;
    private Rigidbody heldObjRb;
=======

{
    [Header("Pickup Setiings")]
    [SerializeField] Transform holdArea;
    private GameObject heldObj;
    private Rigidbody heldObjRb;
    public AudioSource levanta;
    public AudioSource deja;
>>>>>>> a9eb02ed71ad289a8f45c2645ad19e17d64eb8b5

    [Header("Physics Parameters")]
    [SerializeField] private float pickupRange = 5.0f;
    [SerializeField] private float pickupForce = 150.0f;

<<<<<<< HEAD
    // Update is called once per frame
=======

>>>>>>> a9eb02ed71ad289a8f45c2645ad19e17d64eb8b5
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
<<<<<<< HEAD
            if(heldObj == null)
            {
                RaycastHit hit;
                {
                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickupRange))
                    {
                        PickupObject(hit.transform.gameObject);
                    }
                }       
=======
            if (heldObj == null)
            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickupRange))
                {
                    PickupObject(hit.transform.gameObject);
                    levanta.Play();
                }
>>>>>>> a9eb02ed71ad289a8f45c2645ad19e17d64eb8b5
            }
            else
            {
                DropObject();
<<<<<<< HEAD
            }
        }
=======
                deja.Play();
            }
        }

>>>>>>> a9eb02ed71ad289a8f45c2645ad19e17d64eb8b5
        if (heldObj != null)
        {
            MoveObject();
        }
<<<<<<< HEAD
        
=======
>>>>>>> a9eb02ed71ad289a8f45c2645ad19e17d64eb8b5
    }

    void MoveObject()
    {
<<<<<<< HEAD
        if(Vector3.Distance(heldObj.transform.position, holdArea.position) > 0.1f)
=======
        if (Vector3.Distance(heldObj.transform.position, holdArea.position) > 0.1f)
>>>>>>> a9eb02ed71ad289a8f45c2645ad19e17d64eb8b5
        {
            Vector3 moveDirection = (holdArea.position - heldObj.transform.position);
            heldObjRb.AddForce(moveDirection * pickupForce);
        }
    }

    void PickupObject(GameObject pickObj)
    {
        if (pickObj.GetComponent<Rigidbody>())
        {
            heldObjRb = pickObj.GetComponent<Rigidbody>();
            heldObjRb.useGravity = false;
            heldObjRb.drag = 10;
            heldObjRb.constraints = RigidbodyConstraints.FreezeRotation;

            heldObjRb.transform.parent = holdArea;
            heldObj = pickObj;
        }
    }

    void DropObject()
<<<<<<< HEAD
        {
=======
     {
>>>>>>> a9eb02ed71ad289a8f45c2645ad19e17d64eb8b5
            heldObjRb.useGravity = true;
            heldObjRb.drag = 1;
            heldObjRb.constraints = RigidbodyConstraints.None;

<<<<<<< HEAD
            heldObjRb.transform.parent = null;
            heldObj = null;
        }



=======
            heldObj.transform.parent = null;
            heldObj = null;

     }
    
>>>>>>> a9eb02ed71ad289a8f45c2645ad19e17d64eb8b5
}
