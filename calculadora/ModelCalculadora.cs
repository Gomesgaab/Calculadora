using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class ModelCalculadora
    {
        //declarndo variavel 
        private double num1;
        private double num2;
        private double num3;
        public ModelCalculadora()
        {
            GetSetNum1 = 0;
            GetSetNum2 = 0;
            GetSetNum1 = 0;

        }// fim do construtor

        // métodos get set 
        public double GetSetNum1
        {
            get { return this.num1; }
            set { this.num1 = value; }
        } // fi do get set num1

        public double GetSetNum2
        {
            get { return this.num2; }
            set { this.num2 = value; }
        }// fim get set num2

        public double GetSetNum3
        {
            get { return this.num3; }
            set { this.num3 = value; }
        }

        //Métodos 
        public double Somar()
        {
            return GetSetNum1 + GetSetNum2;
        }// fim do metodo somar

        public double Subtrair()
        {
            return GetSetNum1 - GetSetNum2;
        } //Fim do metodo subtrsir 

        public double Dividir()
        {
            if (GetSetNum2 <= 0)
            {
                return -1;

            }
            else
            {
                return GetSetNum1 / GetSetNum2;

            }
        }// fim do dividir 

        public double Multiplicar()
        {
            return GetSetNum1 * GetSetNum2;
        }// fim do multiplicar

        public double Potencia()
        {
            return Math.Pow(GetSetNum1, GetSetNum2);

        }//fim da potencia 

        public string Raiz()
        {
            string msg = "Raiz do primeiro número: " + Math.Sqrt(GetSetNum1) +
                         "\nRaiz do segundo número: " + Math.Sqrt(GetSetNum2);
            return msg;
        }// fim potencia

        public string TabuadaNum1()
        {
            string resultado = "";

            for (int i = 0; i <= 10; i++)
            {
                resultado += "\n" + GetSetNum1 + " * " + i + " = " + (GetSetNum1 * i);
            }// fim for

            return resultado;
        }//fim tabuadaNum1

        public string TabuadaNum2()
        {
            string resultado = "";

            for (int i = 0; i <= 10; i++)
            {
                resultado += "\n" + GetSetNum2 + " * " + i + " = " + (GetSetNum2 * i);
            }// fim for

            return resultado;
        }//fim tabuadaNum2

        public int ConverterDecimal(string binario)
        {
            int dec = 0;
            string caract = "";
            int tamanho = binario.Length;
            int pote = tamanho;
            for (int i = 0; i < tamanho; i++)
            {
                pote--;
                caract = binario.Substring(i, 1);
                if (caract == "1")
                {
                    dec += Convert.ToInt32(Math.Pow(2, pote));
                }
            }//fim do for
            return dec;
        }//fim do método converter decimal

        public string ConverterBinario(int dec)
        {
            string binario = "";
            int resto = 0;
            do
            {
                resto = dec % 2;
                binario += resto;
                dec = dec / 2;
            } while (dec != 0);
            return new String(binario.Reverse().ToArray());
        }//fim do método

        public double ConverterHexaDecimal(string hexadecimal)
        {
            double dec = 0;
            string caract = "";
            int num = 0;
            int tamanho = hexadecimal.Length;
            int pote = tamanho;
            for (int i = 0; i < tamanho; i++)
            {
                pote--;
                caract = hexadecimal.Substring(i, 1);
                switch (caract)
                {
                    case "A":
                        num = 10;
                        break;
                    case "B":
                        num = 11;
                        break;
                    case "C":
                        num = 12;
                        break;
                    case "D":
                        num = 13;
                        break;
                    case "E":
                        num = 14;
                        break;
                    case "F":
                        num = 15;
                        break;
                    default:
                        num = Convert.ToInt32(caract);
                        break;
                }//fim do switch
                dec += num * Math.Pow(16, pote);
            }//fim do for
            return dec;
        }//fim do método converter decimal

        public string ConverterDecimalHexa(int dec)
        {
            int resto = 0;
            string hexadecimal = "";

            do
            {
                resto = dec % 16;
                switch (resto)
                {
                    case 10:
                        hexadecimal += "A";
                        break;
                    case 11:
                        hexadecimal += "B";
                        break;
                    case 12:
                        hexadecimal += "C";
                        break;
                    case 13:
                        hexadecimal += "D";
                        break;
                    case 14:
                        hexadecimal += "E";
                        break;
                    case 15:
                        hexadecimal += "F";
                        break;
                    default:
                        hexadecimal += resto;
                        break;
                }//fim do switch
                dec = dec / 16;
            } while (dec != 0);
            return new string(hexadecimal.Reverse().ToArray());
        }//fim do converter

        public string bhaskara(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta <= 0)
            {
                return "Impossível calcular X1 e X2, Delta: " + delta;
            }
            else
            {
                double X1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double X2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return "Delta: " + delta + "\nX1: " + X1 + "\nX2: " + X2;
            }
        }//fim do bhaskara

        public string ConverterBinarioHexadecimal(string binario)
        {
            int dec = ConverterDecimal(binario);
            string Hex = ConverterDecimalHexa(dec);
            return Hex;
        }//Fim do metodo ConverterBinarioHexadecimal

        public string DobroTriplo()
        {
            string msg = "O dobro é: " + GetSetNum1 * 2 +
                         "\nO triplo é: " + GetSetNum1 * 3;
            return msg;

        }// fim dobrotriplo 

        public double Retorno()
        {
            double total = 0;
            double adicional = 0;
            double porcent = GetSetNum1 / 100;
            adicional = porcent * 30;
            total = GetSetNum1 + adicional;
            return total;
        }// fim retorno porcentagem 

        public string ParouInpar()
        {
            if (GetSetNum1 % 2 == 0)
            {
                return "O núumero citado e par";
            }
            else
            {
                return "O número citado e impar";
            }// fim 
        }// fim do par ou impar

        public int SomaInteiro()
        {
            int resultado = 0;
            for (int i = 0; i <= 100; i++)
            {
                resultado = resultado + i;

            }//fim
            return resultado;
        }// fim somar númeiros inteiros 

        public string TabuadaEscolha(int num1, int num2)
        {
            string resultado = "";

            for (int i = 0; i <= num1; i++)
            {
                resultado += "\n" + num2 + " * " + i + " = " + (num2 * i);
            }// fim for

            return resultado;
        }//fim tabuada você escolhe 

        public string Sequencia(int numI, int numF)
        {
            double i;
            i = 0;
            string resultado = "";
            for (i = numI; i <= numF; i++)
            {
                resultado += "\n" + i;

            }//fim
            return resultado;
        }// fim somar númeiros inteiros 

        public string CemDuzentos()
        {
            string msg = "";

            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0)
                {
                    msg += "\n" + i;
                }// fim

            }// fim
            return msg;
        }// fim Cem a Duzentos 


        public int SomaDezInteiros()
        {
            int numA = 0;
            int num = 0;

            for (int i = 0; i <= 9; i++)
            {

                Console.WriteLine("Informe um número inteiro: ");
                num = Convert.ToInt32(Console.ReadLine());
                numA += num;
                num = 0;
            }
            return numA;
        }// fim somar 10 inteiros 

        public int Atezero()
        {
            int num = 0;
            int numA = 0;
            do
            {
                Console.WriteLine("Informe um número inteiro: ");
                num = Convert.ToInt32(Console.ReadLine());
                numA += num;
            } while (num != 0);
            return numA;
        }// fim ate zero 

        public double Media()
        {
            double num = 0;
            double cont = 0;
            double numA = 0;
            do
            {
                Console.WriteLine("Informe um número: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                {
                    cont += 1;
                    numA += num;

                }// fim do se     

            } while (num != 0);

            return (numA / (cont - 1));
        }// fim da Média 

        public string MaiorMenor()
        {
            int numB = 0;
            Boolean flag = false;
            int maior = 0;
            int menor = 0;
            string msg = "";

            do
            {
                Console.WriteLine("Informe um número: ");
                numB = Convert.ToInt32(Console.ReadLine());

                if (flag == false)
                {
                    maior = numB;
                    menor = numB;
                    flag = true;
                }

                if (numB != 0)
                {
                    if (numB > maior)
                    {
                        maior = numB;
                    }

                    if (numB < menor)
                    {
                        menor = numB;
                    }
                }
                msg = "O maior número é:" + maior + " O menor número é:" + menor;
            } while (numB != 0);

            return msg;
        }// fim da Média

        public string SomaQuantidade()
        {
            int numeracao = 0;
            int cont = 0;
            int negativo = 0;
            string msg = "";

            for (int i = 0; i <= 19; i++)
            {
                Console.WriteLine("Informe um número: ");
                numeracao = Convert.ToInt32(Console.ReadLine());

                if (numeracao >= 0)
                {
                    cont += numeracao;
                }
                if (numeracao < 0)
                {
                    negativo += 1;
                }
                msg = "A soma dos números positivos são: " + cont + " A quantidade de números negativos são: " + negativo;
            }
            return msg;
        }// fim soma quantidade

        public int Fatorial(int num)
        {
            int numA = 1;
            for (int i = 1; i <= num; i++)
            {
                numA *= i;
            }
            return numA;
        }// fim fatorial

        public string Jogadores(int numJ)
        {
            double altura = 0;
            double cont = 0;
            double media = 0;

            for (int i = 1; i <= numJ; i++)
            {
                Console.WriteLine("Informe a altura dos jogadores: ");
                altura = Convert.ToDouble(Console.ReadLine());
                cont += altura;
            }// fim
            media = cont / numJ;
            return "\nA média de altura dos jogadores é:" + "" + media;
        }// fim média de jogadores

        public string NotasCompetidoras()
        {
            string nome = "";
            int nota = 0;
            Boolean flag = false;
            int maiorN = 0;
            string nomeMss = "";

            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("Informe o nome das competidoras: " + i + "º");
                nome = Console.ReadLine();
                Console.WriteLine("Informe a nota dos jogadores: ");
                nota = Convert.ToInt32(Console.ReadLine());
                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("Informe notas validas de 0 a 10: ");
                    nota = 0;
                    i = i - 1;
                }
                if (flag == false)
                {
                    maiorN = nota;
                    nomeMss = nome;
                    flag = true;
                }
                if (nota > maiorN)
                {
                    maiorN = nota;
                    nomeMss = nome;
                }// fim if
            }// fim for

            return "\nA competidora vencedora é: " + nomeMss + " Com a Nota de: " + maiorN;
        }// fim Miss

        public string Eleitores(double brancos, double nulos, double valido, double tEleitores)
        {
            string msg = "";

            double tv = valido / tEleitores * 100;
            double tn = nulos / tEleitores * 100;
            double tb = brancos / tEleitores * 100;

            msg = ("\nPercentual de votos brancos: " + tb + "%" + "\nPercentual votos validos: " + tv + "%" + "\nPercentual votos nulos: " + tn + "%");
            return msg;

        }// fim eleitores

        public double CustoCarro(int cFabrica)
        {
            double fConsumidor = 0;

            fConsumidor = ((cFabrica  * 0.28 ) + cFabrica) + ((cFabrica * 0.45) + cFabrica);

            return fConsumidor;
        }// fim 

        public int IddAnoMeses(int anos, int meses, int dias)
        {
            int idade = 0;

            idade = ((anos * 365) + (meses * 30) + (dias));
            return idade;
        }// fim 

        public string Vetor()
        {
            double maior = 0;

            double[] notas = new double[5];
            for(int i = 0;i <= 4;i++)
            {
                Console.WriteLine(i + 1 + "ª nota");
                notas[i] = Convert.ToDouble(Console.ReadLine());
                if (notas[i] > maior)
                {
                    maior = notas[i];
                }
            }
            return "\nA maior nota é: " + maior;
        }// fim vetor

        public string Vetor2()
        {
            int msgA = 0;
            int msgB = 0;
            int y = 0;
            int i = 0;

                int[] valores = new int[5];
            for( i =0; i <= 4; i++)
            {
                Console.WriteLine(i + 1 + "°");
                valores[i] = Convert.ToInt32(Console.ReadLine());
                if (valores[i] % 2 != 0)
                {
                    int[] valoresN = new int[5];
                    for ( y = 0; y <= 4; y++)
                    {
                    }
                    msgA = valoresN[y] = valores[i];
                }
                if (valores[i] % 2 == 0)
                {
                   msgB = valores[i] = valores[i];
                }
            }
            return "Valores pares é: " + msgA + " Valores impares é: " + msgB;
        }




    }// fim da classe 
}// fim do projeto 
