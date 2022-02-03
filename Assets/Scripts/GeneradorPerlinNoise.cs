using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GeneradorPerlinNoise : MonoBehaviour
{
    public int x, z;
    public GameObject pieza;
    public GameObject agente;
    public NavMeshSurface superficie;
    
    void Start()
    {
        Generar();
        Invoke("GenerarNavMesh", 6);
    }

    private void GenerarNavMesh()
    {
        superficie.BuildNavMesh();
    }

    private void Generar()
    {
        float semilla = Random.Range(0.0f, 1000.0f);
        float escala = 10.0f;
        int proporcion = 50;
        bool existeP = false;

        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < z; j++)
            {
                float corX = semilla + i / escala;
                float corY = semilla + j / escala;

                int r = (int)(Mathf.PerlinNoise(corX, corY) * proporcion);
                if (r < 20)
                {
                    Instantiate(pieza, new Vector3(i * 5, 0, j * 5), Quaternion.identity);

                    int genP = Random.Range(0, 10);

                    if(genP == 5 /*&& existeP == false*/)
                    {
                        Instantiate(agente, new Vector3(i * 5, 3.5f, j * 5), Quaternion.identity);
                        existeP = true;
                    }
                }
            }
        }
    }

}
