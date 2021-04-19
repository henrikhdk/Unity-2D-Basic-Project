using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
        ClasseSemMono semMono = new ClasseSemMono();
        ClasseComMono comMono = this.gameObject.AddComponent<ClasseComMono>();
        Invoke("RetiraOComponente",5);
    }

    // Update is called once per frame
    void RetiraOComponente(){
         Debug.Log("Hello BRBRBR World!");
    }
}
