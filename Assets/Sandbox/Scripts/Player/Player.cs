using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool hasCoin = false;
    private bool availablePickup = false;

    private Transform currentPickupAvailable;

    [SerializeField] private Transform pickupTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (availablePickup)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                PickupCoin();
            }
        }
    }

    public void MakeItemAvailable(Transform coinToPickup)
    {
        currentPickupAvailable = coinToPickup;
        availablePickup = true;
        Debug.Log("Available for pickup!");
    }

    public void MakeItemUnavailable(Transform coinToPickup)
    {
        currentPickupAvailable = null;
        availablePickup = false;
        Debug.Log("Item no longer available to pickup");
    }

    private void PickupCoin()
    {
        currentPickupAvailable.position = pickupTransform.position;
        currentPickupAvailable.SetParent(pickupTransform);
        hasCoin = true;
        Debug.Log("Item has been picked up!");
    }

    public bool HasCoin()
    {
        return hasCoin;
    }
}
