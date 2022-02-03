using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navegacion : MonoBehaviour
{
    private NavMeshAgent personaje;
    // Start is called before the first frame update
    void Start()
    {
        personaje = GetComponent<NavMeshAgent>();
       
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                personaje.destination = hit.point;
            }
        }
    }
}
