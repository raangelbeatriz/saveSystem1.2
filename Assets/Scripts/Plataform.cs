using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataform : MonoBehaviour
{
    private SliderJoint2D slider;
    public JointMotor2D auxiliar;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<SliderJoint2D>();
        auxiliar = slider.motor;
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.limitState == JointLimitState2D.UpperLimit)
        {
            auxiliar.motorSpeed = -4;
            slider.motor = auxiliar;
        }

        if (slider.limitState == JointLimitState2D.LowerLimit)
        {
            auxiliar.motorSpeed = 4;
            slider.motor = auxiliar;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            collision.transform.position = new Vector3(transform.position.x, collision.transform.position.y, collision.transform.position.z);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            collision.transform.SetParent(null);
        }
    }
}

