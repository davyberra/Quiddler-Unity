using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    public GameObject Card;
    public GameObject playerHandArea;
    public GameObject faceDownPile;
    public GameObject discardPile;
    public GameObject goDownArea;
    
    
    



    // Update is called once per frame
    public void OnClick()
    {
        GameObject playerCard = Instantiate(Card, new Vector3(0, 0, 0), Quaternion.identity);
        
        playerCard.transform.SetParent(playerHandArea.transform, false);
    }
}
