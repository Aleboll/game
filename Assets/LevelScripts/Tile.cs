using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public sealed class Tile : MonoBehaviour
{
    public int x;
    public int y;

    private Item _item;
    public Item Item
    {
        get => _item;

        set
        {
            if (_item == value) return;

            _item = value;

            icon.sprite = _item.sprite;
        }

    }

    public Image icon;

    public Button button;

    public Tile Left => x > 0 ? Board.Instance.Tiles[x - 1, y] : null;
    public Tile Top => y > 0 ? Board.Instance.Tiles[x, y - 1] : null;
    public Tile Right => x < Board.Instance.Width - 1 ? Board.Instance.Tiles[x + 1, y] : null;
    public Tile Bottom => y < Board.Instance.Height - 1 ? Board.Instance.Tiles[x, y + 1] : null;

    public Tile[] Neighbours => new[]
    {
        Left,
        Top,
        Right,
        Bottom,
    };

    private void Start()
    {
        button.onClick.AddListener(call: () => Board.Instance.Select(tile: this));
    }

    public List<Tile> GetConnectedTiles(List<Tile> exclude = null)
    {
        if (exclude == null)
        {
            exclude = new List<Tile>();
        }
        exclude.Add(this);

        var result = new List<Tile> { this };

        // Check horizontally (Left and Right)
        foreach (var horizontalTile in new[] { Left, Right })
        {
            if (horizontalTile != null && !exclude.Contains(horizontalTile) && horizontalTile.Item == Item)
            {
                result.AddRange(horizontalTile.GetConnectedTiles(exclude));
            }
        }

        // Check vertically (Top and Bottom)
        foreach (var verticalTile in new[] { Top, Bottom })
        {
            if (verticalTile != null && !exclude.Contains(verticalTile) && verticalTile.Item == Item)
            {
                result.AddRange(verticalTile.GetConnectedTiles(exclude));
            }
        }

        return result;
    }
}