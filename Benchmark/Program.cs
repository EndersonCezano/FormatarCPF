using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<CpfBenchmark>();
            
            /*
            var cpf = new CpfBenchmark();
            var result1 = cpf.FormatarInt();
            var result2 = cpf.FormatarSubstring();
            var result3 = cpf.FormatarInsert();
            var result4 = cpf.FormatarLoop();            
            */
        }
    }

    [MarkdownExporterAttribute.Default]
    [MarkdownExporterAttribute.GitHub]
    [MemoryDiagnoser]
    public class CpfBenchmark
    {
        private readonly string _cpf;

        public CpfBenchmark()
        {            
            _cpf = "12345678909";
        }

        [Benchmark(Baseline = true)]
        public string FormatarInt()
        {
            return Convert.ToUInt64(_cpf).ToString(@"000\.000\.000\-00");
        }

        [Benchmark]
        public string FormatarSubstring()
        {
            return $"{_cpf.Substring(0, 3)}.{_cpf.Substring(3, 3)}.{_cpf.Substring(6, 3)}-{_cpf.Substring(9, 2)}";
        }

        [Benchmark]
        public string FormatarInsert()
        {
            return _cpf.Insert(3, ".").Insert(7, ".").Insert(11, "-");
        }

        [Benchmark]
        public ReadOnlySpan<char> FormatarLoop()
        {
            Span<char> formattedValue = stackalloc char[14];

            Copy(_cpf, startIndex: 0, length: 3, ref formattedValue, insertIndex: 0);
            formattedValue[3] = '.';

            Copy(_cpf, startIndex: 3, length: 3, ref formattedValue, insertIndex: 4);
            formattedValue[7] = '/';

            Copy(_cpf, startIndex: 6, length: 3, ref formattedValue, insertIndex: 8);
            formattedValue[11] = '-';

            Copy(_cpf, startIndex: 9, length: 2, ref formattedValue, insertIndex: 12);

            return formattedValue.ToArray();

            static void Copy(string origin, int startIndex, int length, ref Span<char> destination, int insertIndex)
            {
                for (int i = startIndex, j = insertIndex; i < (startIndex + length); i++, j++)
                    destination[j] = origin[i];
            }
        }
    }
}
