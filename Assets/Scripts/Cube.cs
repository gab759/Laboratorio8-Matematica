using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Vector3 translación = Vector3.zero;
    public float radio = 1f;
    public int vertice = 100; 
        
    void OnDrawGizmos()
    {
        Vector3[] vertices = new Vector3[vertice + 2];

        float phi = Mathf.PI * (3 - Mathf.Sqrt(5)); 

        
        vertices[0] = translación + Vector3.up * radio; 
        vertices[vertice + 1] = translación + Vector3.down * radio; 

        for (int i = 0; i < vertice; i++)
        {
            float y = 1 - ((i + 1) / (float)(vertice + 1)) * 2; 
            float radiusAtY = Mathf.Sqrt(1 - y * y); 

            float theta = phi * (i + 1); 

            float x = Mathf.Cos(theta) * radiusAtY;
            float z = Mathf.Sin(theta) * radiusAtY;

            vertices[i + 1] = new Vector3(x, y, z) * radio + translación;
        }

        for (int i = 0; i < vertice + 2; i++)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawSphere(vertices[i], 0.03f);
        }

        //intento de hacer lineas pipi
        /*for (int i = 0; i < verticesCount + 2; i++)
        {
            // Dibujar línea al vértice siguiente
            if (i < verticesCount + 1)
            {
                Gizmos.color = Color.white;
                //Gizmos.DrawLine(vertices[i], vertices[i + 1]);
            }

            if (i > 0 && i < verticesCount + 1)
            {
                int oppositeIndex = (i + verticesCount / 2 - 1) % verticesCount + 1;
                Gizmos.color = Color.white;
                Gizmos.DrawLine(vertices[i], vertices[oppositeIndex]); 
            }
        }*/
    }
}