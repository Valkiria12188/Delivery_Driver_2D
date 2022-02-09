using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] float destroyDelay = 0.5f; 
    bool hasPackage; //domy�lnie jest false

    SpriteRenderer spriteRenderer; //odwo�anie do sprita samochodu by zmieniac mu kolor

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Auu... Trafi�e� na co�!");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if( other.tag=="Package"&& !hasPackage) //jesli nie masz paczki, mozesz j� wzi��c ( nie mozemy brac wiecej niz 1 paczki
        {
            Debug.Log("Paczka podniesiona!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }

        if (other.tag == "Customer"&& hasPackage)
        {
            Debug.Log("Dostarczono paczk�!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;

        }

    }


}
