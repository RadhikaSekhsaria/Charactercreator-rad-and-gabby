using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourManager : MonoBehaviour
{
    public SpriteRenderer skinTone;
    public SpriteRenderer hat;
    public SpriteRenderer hattop;
    public SpriteRenderer lips;
    public SpriteRenderer haira;
    public SpriteRenderer hairb;
    public SpriteRenderer hairc;
    public SpriteRenderer haird;

    private void Start()
    {

    }

    public void SkinColour1()
    {
        skinTone.color = new Color32(249, 221, 188, 255);
    }

    public void SkinColour2()
    {
        skinTone.color = new Color32(221, 175, 120, 255);
    }

    public void SkinColour3()
    {
        skinTone.color = new Color32(178, 121, 53,255);
    }

    public void SkinColour4()
    {
        skinTone.color = new Color32(103, 61, 10,255);
    }

    public void Hat1()
    {
        hat.color = new Color(0f, 0f, 225f);
        hattop.color = new Color(0f, 0f, 225f);
    }

    public void Hat2()
    {
        hat.color = new Color(225f, 0f, 0f);
        hattop.color = new Color(225f, 0f, 0f);
    }

    public void Hat3()
    {
        hat.color = new Color(0f, 225f, 0f);
        hattop.color = new Color(0f, 225f, 0f);
    }

    public void Hat4()
    {
        hat.color = new Color32(255, 255, 0, 255);
        hattop.color = new Color32(255, 255, 0, 255);
    }

    public void lip1()
    {
        lips.color = new Color(225f, 0f, 0f);
    }

    public void lip2()
    {
        lips.color = new Color32(130, 29, 40, 255);
    }

    public void lip3()
    {
        lips.color = new Color32(236, 52, 126, 255);
    }

    public void lip4()
    {
        lips.color = new Color32(166, 83, 5, 255);
    }

    public void hair1()
    {
        haira.color = new Color(0, 0, 0);
        hairb.color = new Color(0, 0, 0);
        hairc.color = new Color(0, 0, 0);
        haird.color = new Color(0, 0, 0);
    }

    public void hair2()
    {
        haira.color = new Color32(248, 220, 111, 255);
        hairb.color = new Color32(248, 220, 111, 255);
        hairc.color = new Color32(248, 220, 111, 255);
        haird.color = new Color32(248, 220, 111, 255);
    }

    public void hair3()
    {
        haira.color = new Color32(84, 43, 13, 255);
        hairb.color = new Color32(84, 43, 13, 255);
        hairc.color = new Color32(84, 43, 13, 255);
        haird.color = new Color32(84, 43, 13, 255);
    }

    public void hair4()
    {
        haira.color = new Color32(130, 29, 40, 255);
        hairb.color = new Color32(130, 29, 40, 255);
        hairc.color = new Color32(130, 29, 40, 255);
        haird.color = new Color32(130, 29, 40, 255);
    }

}
