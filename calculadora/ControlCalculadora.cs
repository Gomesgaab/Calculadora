using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
     class ControlCalculadora
    {
        // criando um objeto calculadora na mémoria
        ModelCalculadora calculadora = new ModelCalculadora();

        public ControlCalculadora() 
        {
            this.calculadora = new ModelCalculadora();
        }// fim do construtor

        public void Coletar()
        {
            Console.WriteLine("Informe um número: ");
            this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe outro número: ");
            this.calculadora.GetSetNum2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o terceiro número");
            this.calculadora.GetSetNum3 = Convert.ToDouble(Console.ReadLine());
        }// fim do coletar

        public int Menu()
        {
            Console.WriteLine("-----Menu-----"               +
                              "\n0. Sair"                    +
                              "\n1. Somar"                   +
                              "\n2. Subtrair "               +
                              "\n3. Dividir  "               +
                              "\n4. Multiplicar"             +
                              "\n5. Potência"                +
                              "\n6. Raiz"                    +                     
                              "\n7. Tabuada"                 + 
                              "\n8. Bhaskara"                +
                              "\n\nEscolha uma das opções a cima");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }// fim do método menu

        public void Operacao()
        {
            int opcao = 0;
            do
            {


                opcao = Menu();
                Console.Clear();//limpa tela 
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Coletar();
                        Console.WriteLine("Soma: " + this.calculadora.Somar());
                        break;
                    case 2:
                        Coletar();
                        Console.WriteLine("Subtração: " + this.calculadora.Subtrair());
                        break;
                    case 3:
                        Coletar();
                        if (this.calculadora.Dividir() == -1)
                        {
                            Console.WriteLine("Imposivel dividir por zero!: ");
                        }
                        else
                        {
                            Console.WriteLine("Divisão: " + this.calculadora.Dividir());
                        }
                        break;
                    case 4:
                        Coletar();
                        Console.WriteLine("Multiplicar: " + this.calculadora.Dividir());
                        break;
                    case 5:
                        Coletar();
                        Console.WriteLine("Potência: " + this.calculadora.Potencia());
                        break;
                    case 6:
                        Coletar();
                        Console.WriteLine("Raiz: " + this.calculadora.Raiz());
                        break;
                    case 7:
                        Console.WriteLine("Informe um número: ");
                        this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.TabuadaNum1());
                        break;
                    case 8:
                        Coletar();
                        Console.WriteLine(this.calculadora.Bhaskara());
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não e valida: ");
                        break;
                }// fim do swith
            } while (opcao != 0); // fim do while 
        }// fim operação









    }//Fim da classe
}// fim do projeto
