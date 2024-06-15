using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class spawner : MonoBehaviour
{
    public GameObject Muro;
    public float spawrate = 2;
    private float timer = 0;
    public float rango = 3;
    // Start is called before the first frame update
    void Start()
    {
        spawnear();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnear();
        }
    }
    void spawnear()
    {
        float limiteSup = transform.position.y + rango;
        float limiteInf = transform.position.y - rango;

        Instantiate(Muro, new Vector3(transform.position.x,Random.Range(limiteInf,limiteSup)), transform.rotation);
        timer = 0;
    }
}