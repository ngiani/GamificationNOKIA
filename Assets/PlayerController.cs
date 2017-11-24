using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public bool moving;

    [SerializeField] private float speed;
    [SerializeField] private float distanceToStop;

    private Vector3 direction;
    private Queue<NetworkElement> networkQueue;
    private NetworkElement nextNetworkElement;

    // Use this for initialization
    void Start () {

        NetworkPathManager networkPathManager = FindObjectOfType<NetworkPathManager>();
        networkQueue = new Queue<NetworkElement>();

        foreach (NetworkElement networkElement in networkPathManager.path)
        {
            networkQueue.Enqueue(networkElement);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
        if (moving)
        {
            transform.Translate(direction * speed * Time.deltaTime);
            transform.LookAt(nextNetworkElement.transform);

            if (Vector3.Distance(transform.position, nextNetworkElement.transform.position) <= distanceToStop)
            {
                moving = false;
            }
        }

	}

    // Setup travel to next network element to be visited (target, direction, etc..)
    public void SetUpTravel()
    {
        nextNetworkElement = networkQueue.Dequeue();
        direction = nextNetworkElement.transform.position - transform.position;
        
        moving = true;
    }
}
