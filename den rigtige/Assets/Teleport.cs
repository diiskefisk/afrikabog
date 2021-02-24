using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Denne fil skal lægges i assets mappen
 * Dette scribt lægges ind på det object i vil lave til en teleport Transit nøgle
 * Vælg objekt du vil bruge som teleport på Scene eller i Hierechy
 * Inspector skal du enten trække det over eller trykke på knappen [Add Component] > Scripts > #Teleport
 * Så er det to felter der skal udfyldes det er Player feltet og TargetObjekt feltet
 * klik på den lille skydeskive i  Player feltet så kommer der en alfabetisk liste 
 * over alt i Hierehy. Du skal finde FirstPerson-AIO og klikke på den.
 * på samme måd med det sted du vil have man skal ende.
 */

public class Teleport : MonoBehaviour
{
    [SerializeField]
    private GameObject Player ;
    [SerializeField]
    private GameObject TargetObject ;

    void OnTriggerEnter(Collider other)
    {
        Player.transform.position = TargetObject.transform.position;
    }
}
