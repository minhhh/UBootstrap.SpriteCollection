using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UBootstrap
{
    public class SpriteCollection : MonoBehaviour
    {
        public List<Sprite> sprites = new List<Sprite> ();
        public string collectionName;
        public string folderName;
        public Texture2D texture;

        protected virtual void Awake ()
        {
        }

        protected virtual void OnDestroy ()
        {
        }

        public virtual Sprite GetSprite (int index)
        {
            if (index >= 0 && index < sprites.Count) {
                return sprites [index];
            }

            return null;
        }

        public virtual Sprite GetSprite (string spriteName)
        {
            foreach (Sprite sprite in sprites) {
                if (sprite != null && sprite.name == spriteName) {
                    return sprite;
                }
            }
            return null;
        }
    }

}