``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.836 (1909/November2018Update/19H2)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.302
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  DefaultJob : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT


```
|                Method |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |----------:|----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|           FormatarInt | 276.86 ns |  7.559 ns | 21.072 ns | 270.26 ns |  1.00 |    0.00 | 0.0134 |     - |     - |      56 B |
|     FormatarSubstring | 156.32 ns | 12.081 ns | 35.240 ns | 143.49 ns |  0.58 |    0.14 | 0.0629 |     - |     - |     264 B |
| FormatarStringBuilder |  74.71 ns |  1.460 ns |  3.716 ns |  73.64 ns |  0.27 |    0.02 | 0.0381 |     - |     - |     160 B |
|        FormatarInsert |  67.66 ns |  5.311 ns | 15.409 ns |  62.14 ns |  0.24 |    0.06 | 0.0362 |     - |     - |     152 B |
|          FormatarSpan |  30.26 ns |  1.597 ns |  4.635 ns |  28.78 ns |  0.11 |    0.02 | 0.0134 |     - |     - |      56 B |