using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1Event : MonoBehaviour
{
    public EventManager evMan;

    // Start is called before the first frame update
    void Start()
    {
        evMan.SpacebarPressed += MoveUp;
    }

    private void OnDestroy()
    {
        evMan.SpacebarPressed -= MoveUp;
    }

    void MoveUp (float recievedFloat)
    {
        transform.position += new Vector3(0f, recievedFloat, 0f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
