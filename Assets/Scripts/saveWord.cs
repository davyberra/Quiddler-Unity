using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveWord : MonoBehaviour
{
    public GameObject goDownPile;
    public GameObject completedCardsPile;
    public GameObject playerHandArea;
    public Component[] cards;
    private int cardPointTotal;
    private int totalCards;

    private void Awake()
    {
        goDownPile = GameObject.Find("goDownArea");
    }

    public void OnClick()
    {
        cards = goDownPile.GetComponentsInChildren<CardClass>();
        cardPointTotal = 0;
        foreach (CardClass card in cards)
        {
            cardPointTotal += card.points;
        }

        if (cardPointTotal == 6)
        {
            foreach (CardClass card in cards)
            {
                card.transform.SetParent(completedCardsPile.transform, false);
                card.transform.position = completedCardsPile.transform.position;
            
            }
        }
        else
        {
            foreach (CardClass card in cards)
            {
                card.transform.SetParent(playerHandArea.transform, false);
                card.transform.position = playerHandArea.transform.position;
            }
        }
    }
    public void Update()
    {
        cards = goDownPile.GetComponentsInChildren<CardClass>();
        totalCards = 0;

        foreach (CardClass card in cards)
        {
            totalCards++;
        }

        //if (totalCards > 1)
        //{
        //    Blink.StartBlinking();
        //}
    }

}
