using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<Bench>();

[MemoryDiagnoser]
public class Bench
{

    private Random _random = null!;
    private IEnumerable<int> _initialList = null!;

    [Params(1000)]
    public int Size = 1000;

    [GlobalSetup]
    public void Setup()
    {
        _random = new Random(420);
        _initialList = Enumerable.Range(0, Size).Select(_ => _random.Next());
    }

    [Benchmark]
    public int[] ToArray_Init() => _initialList.ToArray();

    [Benchmark]
    public ImmutableArray<int> ImmutableArray_Init() => _initialList.ToImmutableArray();

    [Benchmark]
    public List<int> List_Init() => _initialList.ToList();

    [Benchmark]
    public ImmutableList<int> ImmutableList_Init() => _initialList.ToImmutableList();
}