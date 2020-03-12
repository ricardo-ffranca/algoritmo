﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AlgoritmosDeOrdenacao
{
    public class BubbleSort
    {
        public void Executar()
        {
            var numerosDesordenados = new List<int> { 5, 9, 3, 1, 2, 8, 4, 7, 6 };

            var bubbleSort = new BubbleSort();

            var numerosOrdenados3 = bubbleSort.OrdenarDoFimAoInicio(numerosDesordenados);

            var numerosOrdenados2 = bubbleSort.OrdenarDoInicioAoFim(numerosDesordenados);

            var numerosOrdenados1 = bubbleSort.OrdenarPrimeiraVersao(numerosDesordenados);
        }

        private IEnumerable<int> OrdenarPrimeiraVersao(IEnumerable<int> numerosDesordenados)
        {
            var numerosOrdenados = numerosDesordenados.ToList();

            var posicaoJaOrdenada = 0;

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = numerosOrdenados.Count - 1; i > posicaoJaOrdenada; i--)
            {
                if (numerosOrdenados[i] < numerosOrdenados[i - 1])
                {
                    var posicaoA = numerosOrdenados[i];
                    var posicaoB = numerosOrdenados[i - 1];

                    numerosOrdenados[i] = posicaoB;
                    numerosOrdenados[i - 1] = posicaoA;
                }
                if (i == posicaoJaOrdenada + 1)
                {
                    posicaoJaOrdenada++;
                    i = numerosOrdenados.Count;
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"{nameof(BubbleSort)}.{nameof(OrdenarPrimeiraVersao)} => Fim {stopwatch.Elapsed}");

            return numerosOrdenados;
        }

        private IEnumerable<int> OrdenarDoFimAoInicio(IEnumerable<int> numerosDesordenados)
        {
            var numerosOrdenados = numerosDesordenados.ToList();

            var moverNumero = 0;

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int write = 0; write < numerosOrdenados.Count; write++)
            {
                for (int sort = numerosOrdenados.Count - 1; sort > write; sort--)
                {
                    if (numerosOrdenados[sort] < numerosOrdenados[sort - 1])
                    {
                        moverNumero = numerosOrdenados[sort - 1];
                        numerosOrdenados[sort - 1] = numerosOrdenados[sort];
                        numerosOrdenados[sort] = moverNumero;
                    }
                }
            }

            stopwatch.Stop();
            Console.WriteLine($"{nameof(BubbleSort)}.{nameof(OrdenarDoFimAoInicio)}  => Fim {stopwatch.Elapsed}");

            return numerosOrdenados;
        }

        private IEnumerable<int> OrdenarDoInicioAoFim(IEnumerable<int> numerosDesordenados)
        {
            var numerosOrdenados = numerosDesordenados.ToList();

            var moverNumero = 0;

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int write = 0; write < numerosOrdenados.Count; write++)
            {
                for (int sort = 0; sort < numerosOrdenados.Count - (write + 1); sort++)
                {
                    if (numerosOrdenados[sort] > numerosOrdenados[sort + 1])
                    {
                        moverNumero = numerosOrdenados[sort + 1];
                        numerosOrdenados[sort + 1] = numerosOrdenados[sort];
                        numerosOrdenados[sort] = moverNumero;
                    }
                }
            }

            stopwatch.Stop();
            Console.WriteLine($"{nameof(BubbleSort)}.{nameof(OrdenarDoInicioAoFim)}  => Fim {stopwatch.Elapsed}");

            return numerosOrdenados;
        }
    }
}