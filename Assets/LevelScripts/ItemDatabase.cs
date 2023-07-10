
using UnityEngine;

public static class ItemDatabase
{
    public static Item[] Items { get; private set; }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]private static void Initialize() => Items = Resources.LoadAll<Item>(path: "Items/");
}
