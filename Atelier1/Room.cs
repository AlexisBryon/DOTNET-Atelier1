namespace Atelier1;

public sealed class Room : Tile {
    public Room(ICollectable? collectable = null) {
        Collectable = collectable;
    }
    public ICollectable? Collectable { get; private set; }

    public override bool IsTraversable => true;

    public override bool Pass() => true;

    public ICollectable? Take() {
        ICollectable? collectable = Collectable;
        Collectable = null;
        return collectable;
    }
}