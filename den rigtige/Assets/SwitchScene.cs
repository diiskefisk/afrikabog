/************************************************************
 * At skifte Scene                                          *
 * Du ska have en udgangsscene hvor der er en FP og         *
 * en anden scene hvor der også er en FP på                 *
 * - den scene du vil springe til.                          *
 *                                                          *
 * Scripet her er inspireredet af denne video.              *
 * se den.                                                  *
 * https://www.youtube.com/watch?v=9lPCv9kkbSI              *
 * og prøv hans script det skal du selv skrive.             *
 * Det VIGIG at du gør hvad har siger at du skal gøre.      *
 *                                                          *
 * Når det virke for dig kan du bruge dette da jeg har      *
 * skrevet om på det så det samme script kan bruge          *
 * mange steder.                                            *
 *                                                          *
 * Jeg har ændret med denne variable der skal skrives       *
 * ude i inspectoren. der er sådan et felt                  *
 * [SerializeField]    Laver feltet man kan skrive i        *
 * private int sceneIndex;                                  *
*************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    [SerializeField]
    private int sceneIndex;
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
