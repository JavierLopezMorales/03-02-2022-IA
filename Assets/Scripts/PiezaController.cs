using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiezaController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("QuitarParedes", 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuitarParedes()
    {
        GameObject norte = transform.GetChild(0).gameObject;
        GameObject sur = transform.GetChild(1).gameObject;
        GameObject este = transform.GetChild(2).gameObject;
        GameObject oeste = transform.GetChild(3).gameObject;

        if(Physics.Raycast(transform.position, transform.forward * -1, 5)){
            Destroy(norte);
        }

        if (Physics.Raycast(transform.position, transform.forward , 5)){
            Destroy(sur);
        }

        if (Physics.Raycast(transform.position, transform.right*-1 , 5)){
            Destroy(este);
        }

        if (Physics.Raycast(transform.position, transform.right, 5)){
            Destroy(oeste);
        }
    }
}
