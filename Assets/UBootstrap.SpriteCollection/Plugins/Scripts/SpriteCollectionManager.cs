using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using USingleton;

namespace UBootstrap
{
    public class SpriteCollectionManager : GameSingleton <SpriteCollectionManager>
    {
        List<SpriteCollection> AllCollections = new List<SpriteCollection> ();

        public SpriteCollection GetCollection (string collectionName)
        {
            var collection = AllCollections.Find (c => c.collectionName == collectionName);

            if (collection == null) {
                collection = (Resources.Load (collectionName) as GameObject).GetComponent<SpriteCollection> ();
                SetCollection (collectionName, collection);
            }

            return collection;
        }

        public void SetCollection (string collectionName, SpriteCollection spriteCollection)
        {
            if (spriteCollection == null) {
                return;
            }
            spriteCollection.collectionName = collectionName;
            AllCollections.Add (spriteCollection);
        }

        /// This remove the collection from our internal List,
        /// however, it does not DESTROY the prefab. To really unload the prefab, we have
        /// to call Resources.UnloadUnusedAssets. This is a heavy call, so try to call it
        /// in appropriate places.
        public void DestroyCollection (string collectionName)
        {
            var collection = AllCollections.Find (c => c.collectionName == collectionName);
            if (collection != null) {
                AllCollections.Remove (collection);
            }
        }

    }
}

