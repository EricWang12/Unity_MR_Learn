using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCube : MonoBehaviour
{
    public int NumOfCube = 1;

    private Transform target;
    private GameObject cube;
    // Start is called before the first frame update
    void Start()
    {

        create();

    }

    // Update is called once per frame
    void Update()
    {

    }
    void create()
    {
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(0, 0.15f, 0);
        cube.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        Instantiate(cube);

    }
}
