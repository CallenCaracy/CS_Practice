public class ComputerBuilder
{
    private readonly Computer _computer = new();

    public ComputerBuilder SetCPU(string cpu)
    {
        _computer.CPU = cpu;
        return this;
    }

    public ComputerBuilder SetGPU(string gpu)
    {
        _computer.GPU = gpu;
        return this;
    }

    public ComputerBuilder SetRam(string ram)
    {
        _computer.Ram = ram;
        return this;
    }

    public ComputerBuilder SetStorage(string storage)
    {
        _computer.Storage = storage;
        return this;
    }

    // Lambda
    public Computer Build() => _computer;
}

// public class Builder
// {
//     private readonly Computer _pc = new();

//     public Builder SetCPU(string cpu)
//     {
//         _pc.CPU = cpu;
//         return this;
//     }

//     public Builder SetGPU(string gpu)
//     {
//         _pc.GPU = gpu;
//         return this;
//     }

//     public Builder SetRam(string ram)
//     {
//         _pc.Ram = ram;
//         return this;
//     }

//     public Builder SetStorage(string storage)
//     {
//         _pc.Storage = storage;
//         return this;
//     }

//     public Computer Build() => _pc;
// }