using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizador_Lexico
{
    class Token
    {
       public  enum Tipo
        { 
            NUMERO_INTEIRO,
            OPERADOR_SOMA,
            OPERADOR_SUBTRACAO,
            OPERADOR_DIVISAO,
            OPERADOR_MULTIPLICACAO,
            PONTUACAO_PARENTESES_ESQUERDO,
            PONTUACAO_PARENTESES_DIREITO
        }

        private Tipo tipoToken;
        private String valor;

        public Token(Tipo tipoDeToken, String val) {
            this.tipoToken = tipoDeToken;
            this.valor = val;
        
        }

        public String Getval() {

            return valor;
        
        }
        public String GetTipo() {
            switch (tipoToken)
            {
                case Tipo.NUMERO_INTEIRO:
                    return "Numero inteiro --> ";
                case Tipo.OPERADOR_DIVISAO:
                    return "OPerador de divisão --> ";
                case Tipo.OPERADOR_MULTIPLICACAO:
                    return "Operador de multiplicação --> ";
                case Tipo.OPERADOR_SOMA:
                    return "Operador de adição --> ";
                case Tipo.OPERADOR_SUBTRACAO:
                    return "Operador de subtração --> ";
                case Tipo.PONTUACAO_PARENTESES_DIREITO:
                    return "Parenteses direito --> ";
                case Tipo.PONTUACAO_PARENTESES_ESQUERDO:
                    return "Parenteses esquerdo --> ";
                default:
                    return "Tipo desconhecido";





            }
        
        }
    }
}
