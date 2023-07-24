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
            string msg = "O dobro é: " + GetSetNum1  * 2 +
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
            for(int i = 0; i <= 100; i++)
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



    }// fim da classe 
}// fim do projeto 
