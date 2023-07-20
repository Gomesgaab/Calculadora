using System;
using System.Collections.Generic;
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

        public double Dividir ()
        {
            if(GetSetNum2 <= 0)
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
            return GetSetNum1* GetSetNum2; 
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

            for(int i = 0;i <= 10; i++)
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

        public double Bhaskara()
        {
            return ( -GetSetNum2 + Math.Sqrt(Math.Pow(GetSetNum2,2) - (4 * GetSetNum1 + GetSetNum3))) / 2 * GetSetNum1;

        }// fim bhask





    }// fim da classe 
}// fim do projeto 
