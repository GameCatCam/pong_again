using Godot;

public partial class GlobalData : Node {
    // Singleton instance
    private static GlobalData instance;

    // Data to be shared between scenes
    public string WinnerName { get; set; }

    public override void _Ready() {
        // Ensure there is only one instance of the singleton
        if (instance == null) {
            instance = this;
            // Make the instance persist across scenes
            SetProcess(false);
            SetPhysicsProcess(false);
            SetProcessInput(false);
            // Ensure the singleton is not destroyed when changing scenes
            // Make the singleton a part of the scene tree
            AddToGroup("global");
        } else {
            // Destroy this instance if another one already exists
            QueueFree();
        }
    }

    // Method to retrieve the singleton instance
    public static GlobalData GetInstance() {
        return instance;
    }
}
