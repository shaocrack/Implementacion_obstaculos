using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //para guardar la textura creamos una variable
    public Renderer fondo;
    public GameObject col;
    public float velocidad = 2;
    public GameObject pidra1;
    public GameObject teamo;
    public GameObject teamo3;

    public List<GameObject> cols;
    public List<GameObject> obstaculos;

    // Start is called before the first frame update
    void Start()
    {
        //crear mapa
        for (int i = 0; i < 21; i++)
        {
           cols.Add(Instantiate(col, new Vector2(-10 + i, -3), Quaternion.identity));
        }
        //crear piedra
        obstaculos.Add(Instantiate(pidra1, new Vector2(-14 ,-2), Quaternion.identity));
        obstaculos.Add(Instantiate(teamo, new Vector2(-18, -2), Quaternion.identity));
        obstaculos.Add(Instantiate(teamo3, new Vector2(-18, -2), Quaternion.identity));
    }

    // Update is called once per frame
    void Update()
    {
        //el vector es para moverlo y se movera en x y en yo no se movera
      fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2(0.02f,0)*Time.deltaTime;
        //mover mapa
        for (int i = 0; i < cols.Count; i++)
        {
            if (cols[i].transform.position.x <=-10) 
            {
                cols[i].transform.position = new Vector3(10, -3, 0);
            }
            cols[i].transform.position = cols[i].transform.position + new Vector3(-1, 0,0)*Time.deltaTime *velocidad;
        }

        //mover obstaculos
        for (int i = 0; i < obstaculos.Count; i++)
        {
            if (obstaculos[i].transform.position.x <= -10)
            {
                float randomObs = Random.Range(11, 18);
                obstaculos[i].transform.position = new Vector3(randomObs,-2,0);
            }
            obstaculos[i].transform.position = obstaculos[i].transform.position + new Vector3(-1, 0, 0) * Time.deltaTime * velocidad;
        }
    }
}
