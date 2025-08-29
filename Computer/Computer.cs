public class Computer
{
    public string? CPU  { get; set; }

    public string? GPU { get; set; }

    public string? Ram { get; set; }

    public string? Storage { get; set; }

    public override string ToString() =>
        $"GPU: {GPU}, CPU: {CPU}, Ram: {Ram}, Storage: {Storage}";
}