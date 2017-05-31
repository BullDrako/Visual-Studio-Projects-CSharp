using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {
        //Atributos
        private float op1;
        private float op2;
        private float resultado;

        //Constructor
        public Calculadora()
        {

        }

        public Calculadora(float op1, float op2)
        {
            this.op1 = op1;
            this.op2 = op2;
        }

        //Getters y Setters
        public float getOp1()
        {
            return this.op1;
        }

        public void setOp1(float op1)
        {
            this.op1 = op1;
        }

        public float getOp2()
        {
            return this.op2;
        }

        public void setOp2(float op2)
        {
            this.op2 = op2;
        }

        
        //Metodos
        public float Sumar()
        {
            this.resultado = getOp1() + getOp2();
            return this.resultado;
        }

        public float Restar()
        {
            this.resultado = getOp1() - getOp2();
            return (this.resultado);
        }

        public float Multiplicar()
        {
            this.resultado = getOp1() * getOp2();
            return (this.resultado);
        }

        public float Dividir()
        {
            this.resultado = getOp1() / getOp2();
            return (this.resultado);
        }


       public void Operar(float op1, float op2, int operacion)
        {

            switch (operacion)
            {
                case 1:
                    Console.Write(op1 + " + " +  op2 + " = " + Sumar() + "\n");
                    break;
                case 2:
                    Console.Write(op1 + " - " + op2 + " = " + Restar() + "\n");
                    break;
                case 3:
                    Console.Write(op1 + " * " + op2 + " = " + Multiplicar() + "\n");
                    break;
                case 4:
                    Console.Write(op1 + " / " + op2 + " = " + Dividir() + "\n");
                    break;
            }
        }

        //toString
        public String ResultadoFinal()
        {
             String value =  "El resultado es " + this.resultado + "." ;

             return value;
            
        }

    }
}
