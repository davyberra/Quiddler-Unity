﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    public GameObject Card;
    public GameObject CardA;
    public GameObject playerHandArea;
    public GameObject faceDownPile;
    public GameObject discardPile;
    public GameObject goDownArea;
    
    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject D;
    public GameObject E;
    public GameObject F;
    public GameObject G;
    public GameObject H;
    public GameObject I;
    public GameObject J;
    public GameObject K;
    public GameObject L;
    public GameObject M;
    public GameObject N;
    public GameObject O;
    public GameObject P;
    public GameObject Q;
    public GameObject R;
    public GameObject S;
    public GameObject T;
    public GameObject U;
    public GameObject V;
    public GameObject W;
    public GameObject X;
    public GameObject Y;
    public GameObject Z;
    public GameObject ER;
    public GameObject IN;
    public GameObject CL;
    public GameObject TH;
    public GameObject QU;
    List<GameObject> cardList = new List<GameObject>();

    void Start()
    {
        

        cardList.Add(A);
        cardList.Add(B);
        cardList.Add(C);
        cardList.Add(D);
        cardList.Add(E);
        cardList.Add(F);
        cardList.Add(G);
        cardList.Add(H);
        cardList.Add(I);
        cardList.Add(J);
        cardList.Add(K);
        cardList.Add(L);
        cardList.Add(M);
        cardList.Add(O);
        cardList.Add(P);
        cardList.Add(Q);
        cardList.Add(R);
        cardList.Add(S);
        cardList.Add(T);
        cardList.Add(U);
        cardList.Add(V);
        cardList.Add(W);
        cardList.Add(X);
        cardList.Add(Y);
        cardList.Add(Z);
        cardList.Add(CL);
        cardList.Add(ER);
        cardList.Add(IN);
        cardList.Add(TH);
        cardList.Add(QU);


    }



        // Update is called once per frame
        public void OnClick()
    {
        
        GameObject playerCard = Instantiate(cardList[Random.Range(0, cardList.Count)], new Vector3(0, 0, 0), Quaternion.identity);
        
        
        playerCard.transform.SetParent(playerHandArea.transform, false);
        
    }
}
