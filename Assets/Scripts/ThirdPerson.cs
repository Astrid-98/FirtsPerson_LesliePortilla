using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPerson : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private float smoothTime;
    private CharacterController controller;
    private float velocidadRotacion;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void MoverRotar()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector2 input = new Vector2 (h, v).normalized;

        if (input.magnitude > 0)
        {
            //Calculo el angulo al que tengo que rotarme en funcion de los inputs y camara.
            float angulo = Mathf.Atan2(input.x, input.y) * Mathf.Rad2Deg + Camera.main.transform.eulerAngles.y;

            //creo mi metodo anguloSuave y lo llamo desde el transform
            float anguloSuave = Mathf.SmoothDampAngle(transform.eulerAngles.y, angulo, ref velocidadRotacion, smoothTime);

            transform.eulerAngles = new Vector3(0, anguloSuave, 0);

            Vector3 movimiento = Quaternion.Euler(0, angulo, 0) * Vector3.forward;

            controller.Move(movimiento * velocidadMovimiento * Time.deltaTime);
        }
        

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
