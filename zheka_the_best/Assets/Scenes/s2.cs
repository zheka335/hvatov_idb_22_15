using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class s2 : MonoBehaviour
{
    public float Speed = 10f;
    public int a;
    public int b;
    public int c;
    public GameObject sphere;
    public Text x;

    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * 10 * Speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 10 * Speed * Time.deltaTime);
        }

        if(c <=  0)
        {
            this.gameObject.SetActive(false);
            x.text ="HP:" + c.ToString();
        }
    }

        public void OnCollisionEnter(Collision collision)
        {
            Debug.Log("CEN");
            this.gameObject.GetComponent<Renderer>().material.color = Color.red;
            c--;
            x.text = "HP:" + c.ToString();
            
        }
         public void OnCollisionExit(Collision collision)
        {
            Debug.Log("CET");
            this.gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
         public void OnCollisionStay(Collision collision)
        {
            Debug.Log("TE");
        }
       
       public void heal()
       {
        c = 5;
        this.gameObject.SetActive(true);
       }
    
}
