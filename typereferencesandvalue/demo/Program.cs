﻿using System;
using static System.Console;
public class Program
{
    static void Demo5()
    {
        int[] pares = new int[] { 0, 2, 5, 6, 8 };
        MudarParaImpar(pares);
        WriteLine($" Os impares  {string.Join(",", pares)}");
    }
    static void Demo4()
    {
        string nome = "Gabriel";
        TrocarNome(nome, "José");
        WriteLine($"O novo nome é = {nome}");
    }
    static void Demo3()
    {
        StructPessoa p1 = new() { Documento = "12345", Idade = 20, Nome = "Gabriel" };
        var p2 = p1;
        TrocarNome(p1, "José");
        WriteLine($"O nome de p1 é = {p1.Nome}, \n e o nome de p2 é = {p2.Nome}");
    }
    static void Demo2()
    {
        Pessoa p1 = new();
        p1.Nome = "Gabriel";
        p1.Idade = 20;
        p1.Documento = "1234";

        Pessoa p2 = p1.Clone();


        TrocarNome(p1, "Jose");
        WriteLine($"O nome de p1 é = {p1.Nome}, \n e o nome de p2 é = {p2.Nome}");
    }
    static void Demo1()
    {
        int a = 2;
        a = Adicionar20(a);

        WriteLine($"O valor da variavel a é {a}");
    }
    static int Adicionar20(int a)
    {
        return a + 20;
    }
    static void TrocarNome(Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }

    static void TrocarNome(StructPessoa p1, string novoNome) => p1.Nome = novoNome;
    static void TrocarNome(string nome, string nomeNovo) => nome = nomeNovo;
    static void MudarParaImpar(int[] pares)
    {
        for (int i = 0; i < pares.Length; ++i)
        {
            pares[i] += 1;
        }
    }
    static int EncontrarNumero(int[] numeros, int numero)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == numero)
            {
                return i;
            }
        }
        return -1;
    }
    public static void Main()
    {
        int[] numeros = new int[] { 0, 2, 4, 6, 8 };
        WriteLine("Digite o numero que voce quer encontrar");
        var numero = int.Parse(ReadLine());
        var idxEncontrado = EncontrarNumero(numeros, numero);
        if (idxEncontrado > 0)
        {
            WriteLine($"{idxEncontrado}");
        }
        else
        {
            WriteLine($"Não foi encontrado");
        }
    }
}