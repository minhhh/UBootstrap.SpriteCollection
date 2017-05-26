# SpriteCollection

SpriteCollection is a convenient way to load sprites dynamically in Unity. The reason we use it instead of just putting the sprites in `Resources` folder is because sprites in `Resources` folder cannot be packed in atlases.

**Usage**

1. Create a prefab with one component `SpriteCollection` for each folder of sprites.
2. Fill in the correct folder name, e.g. if your folder is `Assets/Textures/Icons`, you would type `Textures/Icons` into `Folder Name`
3. Click `Reload`, this will populate the `Sprites` array with the correct sprites. You can also change `Sprites` manually in Editor.
4. In game, use `SpriteCollectionManager` to retrieve `SpriteCollection`. First you have to call `SpriteCollectionManager.CreateInstance ()` once at the beginning of the game
5. Then you can load appropriate `SpriteCollection` when needed. For instance, if you have a `SpriteCollection` prefab called `SpriteCollections/Icons` inside `Resources`, you would call:

    ```
    var spriteCollection = SpriteCollectionManager.GetCollection ("SpriteCollections/Icons")
    ```
6. Use the `SpriteCollection` like so:

    ```
    spriteCollection.GetSprite ("Bracer")
    ```


There's a sample scene called `Test` for you to try.


To include SpriteCollection into your project, you can use `npm` method of unity package management described [here](https://github.com/minhhh/UBootstrap).

## Changelog

**0.0.2**

* Fix potential confusing namespace Editor

**0.0.1**

* Initial commit

<br/>

