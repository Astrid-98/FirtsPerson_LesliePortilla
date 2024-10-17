using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFirtsPerson : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento;
    CharacterController controller;
    

    // Start is called before the first frame update
    void Start()
    {
      controller =  GetComponent<CharacterController>(); // A mi variable CharacterController le doy el valor igualalandola
    }

    // Update is called once per frame
    void Update()
    {
        MoverYRotar();
    }
    void MoverYRotar()
    {
        float h = Input.GetAxisRaw("Horizontal"); // h = 0, h = -1, h = 1
        float v = Input.GetAxisRaw("Vertical"); // creo la variable float para coger el input

        Vector3 movimiento = new Vector3 (h, 0, v).normalized;

        //Atan2 es arcotangente
        float anguloRotacion = Mathf.Atan2(movimiento.x, movimiento.z) * Mathf.Rad2Deg + Camera.main.transform.eulerAngles.y; //Alineandome al angulo de la camara = Angulo al que Yo voy a rotar mi cuerpo dependiendo de a donde  mire.
        
        if(movimiento.magnitude > 0)
        {
            //Mi cuerpo queda orientado hacia donde me muevo
            transform.eulerAngles = new Vector3(0, anguloRotacion, 0);

            //me muevo hacia donde estoy orientado
            controller.Move(movimiento * velocidadMovimiento * Time.deltaTime); //con Time.deltaTime time porque esto no va por fisicas.
        }
        

    }
}
