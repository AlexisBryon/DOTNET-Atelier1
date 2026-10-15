namespace Atelier1;

public sealed class Door : Tile {
    private bool _isOpen; 

    public Key Key { get; } = new Key(); 

    public override bool IsTraversable => _isOpen;

    public override bool Pass() => _isOpen;

    public bool TryOpen(Key key) {
        if (!IsKeyOf(key)) {
            return false;
        }

        _isOpen = true;
        return true;
    }

    public bool TryClose(Key key) {
        if (!IsKeyOf(key)) {
            return false;
        }

        _isOpen = false;
        return true;
    }
    private bool IsKeyOf(Key key) => ReferenceEquals(key, Key);
}