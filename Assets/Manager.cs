using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    int number = 20;
    public List<Boid> boids;


    // Start is called before the first frame update
    void Start()
    {
        boids = new List<Boid>();
        for (int i = 0; i < number; i++)
        {
            var newThing = GameObject.CreatePrimitive(PrimitiveType.Cube);
            newThing.transform.position = new Vector3(Random.Range(-100, 100), 10, Random.Range(-100, 100));
            var boid = newThing.AddComponent<Boid>();
            boids.Add(boid);
            boid.manager = this;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
