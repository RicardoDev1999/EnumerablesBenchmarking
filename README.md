BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.1219/21H2)
AMD Ryzen 7 5800X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2


|              Method | Size |      Mean |     Error |    StdDev |   Gen0 |   Gen1 | Allocated |
|-------------------- |----- |----------:|----------:|----------:|-------:|-------:|----------:|
|        ToArray_Init | 1000 |  8.430 us | 0.0251 us | 0.0222 us | 0.2289 |      - |   3.93 KB |
| ImmutableArray_Init | 1000 |  8.216 us | 0.0595 us | 0.0556 us | 0.2289 |      - |   3.93 KB |
|           List_Init | 1000 |  8.924 us | 0.0340 us | 0.0301 us | 0.2289 |      - |   3.96 KB |
|  ImmutableList_Init | 1000 | 18.874 us | 0.1774 us | 0.1659 us | 3.1128 | 0.6104 |  50.86 KB |