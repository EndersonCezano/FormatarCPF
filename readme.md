``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.836 (1909/November2018Update/19H2)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.302
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  DefaultJob : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT


```
|            Method    |      Mean |    Error |   StdDev | Ratio 
|--------------------- |----------:|---------:|---------:|------:
|    FormatarCpfInt    | 252.66 ns | 4.780 ns | 5.114 ns |  1.00
| FormatarCpfSubstring | 115.27 ns | 2.028 ns | 1.897 ns |  0.46
