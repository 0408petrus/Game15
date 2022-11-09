using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public Attack AttackValue;
    public CardPlayer player;
    public Vector2 OriginalPosition;
    Vector2 originalScale;
    Color originalColor;
    bool isClickable = true;

    private void Start()
    {
        OriginalPosition = this.transform.position;
        originalScale = this.transform.localScale;
        originalColor = GetComponent<Image>().color;
        /*        var seq = DOTween.Sequence();

                seq.Append(transform.DOMove(atkPosRef.position, 5));
                seq.Append(transform.DOMove(startPosition, 5));*/
    }
    public void OnClick()
    {
        if (isClickable)
            player.SetChoosenCard(this);
    }
    internal void Reset()
    {
        transform.position = OriginalPosition;
        transform.localScale = originalScale;
        GetComponent<Image>().color = originalColor;
    }

    public void SetClickable(bool value)
    {
        isClickable = value;
    }

    /*
        float timer = 0;

        private void Update()
        {
            if (timer <= 1) {
                var newX = Linear(startPosition.x, atkPosRef.position.x, timer);
                var newY = Linear(startPosition.y, atkPosRef.position.y, timer);
                this.transform.position = new Vector2(newX, newY);
                timer += Time.deltaTime;
                    }
            else
            {
                timer = 0;
            }

        }

        private float Linear(float start,float end,float time)
        {
            return (end - start) * time + start;
        }*/
}
