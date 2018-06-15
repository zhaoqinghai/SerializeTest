``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i5-5200U CPU 2.20GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
Frequency=2143474 Hz, Resolution=466.5324 ns, Timer=TSC
  [Host]     : .NET Framework 4.7.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2633.0  [AttachedDebugger]
  DefaultJob : .NET Framework 4.7.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2633.0


```
|                   Method |        Mean |     Error |    StdDev |    StdErr |         Min |          Q1 |      Median |          Q3 |         Max |     Op/s |    Gen 0 |   Gen 1 | Allocated |
|------------------------- |------------:|----------:|----------:|----------:|------------:|------------:|------------:|------------:|------------:|---------:|---------:|--------:|----------:|
|  NewtonJsonSerializeTest |   447.28 us |  4.180 us |  3.910 us | 1.0095 us |   440.90 us |   444.81 us |   447.80 us |   450.00 us |   455.65 us |  2,235.7 |  60.5469 |       - |   93.5 KB |
|           NewtonJsonTest | 1,626.54 us | 27.298 us | 25.534 us | 6.5929 us | 1,591.99 us | 1,602.37 us | 1,622.74 us | 1,643.86 us | 1,687.07 us |    614.8 | 101.5625 | 42.9688 | 367.01 KB |
|     MsgPackSerializeTest |   385.50 us |  7.706 us |  9.746 us | 2.0322 us |   372.68 us |   377.97 us |   383.98 us |   389.57 us |   409.62 us |  2,594.0 |  29.7852 |       - |  46.16 KB |
|              MsgPackTest |   387.12 us |  3.790 us |  3.545 us | 0.9154 us |   383.02 us |   384.36 us |   386.53 us |   389.30 us |   396.71 us |  2,583.1 |  29.7852 |       - |  46.25 KB |
|    ProtobufSerializeTest |   140.40 us |  1.411 us |  1.319 us | 0.3407 us |   138.45 us |   139.19 us |   140.21 us |   141.54 us |   142.97 us |  7,122.4 |  14.8926 |       - |  23.06 KB |
|             ProtobufTest |   158.14 us |  2.626 us |  2.456 us | 0.6342 us |   154.77 us |   156.12 us |   157.32 us |   160.12 us |   162.68 us |  6,323.7 |  15.1367 |       - |  23.54 KB |
| MessagePackSerializeTest |    64.10 us |  1.239 us |  1.521 us | 0.3243 us |    61.66 us |    63.22 us |    63.81 us |    65.30 us |    67.84 us | 15,600.6 |   8.1787 |       - |  12.74 KB |
|          MessagePackTest |   151.05 us |  3.049 us |  6.944 us | 0.8819 us |   140.29 us |   146.33 us |   150.08 us |   154.53 us |   173.48 us |  6,620.1 |  24.4141 |       - |  37.75 KB |
