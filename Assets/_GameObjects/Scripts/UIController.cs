using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text PhysicsTxT;
    public string PhysicsString;
    Rigidbody rbPajaro;//Rigidbody del pájaro
    private void Start()
    {
        rbPajaro = GameObject.Find("Pollo").GetComponent<Rigidbody>();
    }
    //private void Update()
    //{
    //    if (GameManager.physics == true)
    //    {
    //        PhysicsString = "Physics: ON";
    //    }
    //}
    public void Jugar()
    {
        GameManager.playing = true;
        rbPajaro.isKinematic = false;
    }
    //public void Physics()
    //{
    //    if (GameManager.physics == true)
    //    {
    //        GameManager.physics = false;
    //    }
    //    else
    //    {
    //        GameManager.physics = true;
    //    }
    //}
    public void Reiniciar()
    {
        GameManager.Reload();
    }
}
