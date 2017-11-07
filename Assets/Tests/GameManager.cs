using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UBootstrap;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    SpriteCollection transparentIconsSC;

    // Use this for initialization
    void Start ()
    {
        SpriteCollectionManager.CreateInstance ();

        SpriteCollection spriteCollection = SpriteCollectionManager.Instance.GetCollection ("Icons");
        Debug.Log (spriteCollection.GetSprite ("Bracer_0"));
        Debug.Log (spriteCollection.GetSprite ("Runestone_Blue"));
        Debug.Log (spriteCollection.GetSprite ("Scroll"));
        Debug.Log (spriteCollection.GetSprite ("Sword"));

        SpriteCollectionManager.Instance.SetCollection ("TransparentIcons", transparentIconsSC);
        spriteCollection = SpriteCollectionManager.Instance.GetCollection ("TransparentIcons");

        Debug.Log (spriteCollection.GetSprite ("T_Bracer"));
        Debug.Log (spriteCollection.GetSprite ("T_Runestone_Blue"));
        Debug.Log (spriteCollection.GetSprite ("T_Scroll"));
        Debug.Log (spriteCollection.GetSprite ("T_Sword"));
    }

    // Update is called once per frame
    void Update ()
    {

    }
}
