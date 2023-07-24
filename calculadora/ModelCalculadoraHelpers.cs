using System;

internal static class ModelCalculadoraHelpers
{

    public static int BinarioParaDecimal(string valorBinario)
    {
        int expoente = 0;
        int numero;
        int soma = 0;
        string numeroInvertido = InverterString(valorBinario);
        for (int i = 0; i < numeroInvertido.Length; i++)
        {
            //pega dígito por dígito do número digitado
            numero = Convert.ToInt32(numeroInvertido.Substring(i, 1));
            //multiplica o dígito por 2 elevado ao expoente
            // e armazena o resultado em soma
            soma += numero * (int)Math.Pow(2, expoente);
            // incrementa o expoente
            expoente++;
        }
        return soma;
    }
    public static string InverterString(string str)
    {
        int tamanho = str.Length;
        char[] caracteres = new char[tamanho];
        for (int i = 0; i < tamanho; i++)
        {
            caracteres[i] = str[tamanho - 1 - i];
        }
        return new string(caracteres);
    }
}