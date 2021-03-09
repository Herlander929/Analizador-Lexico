using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizador_Lexico
{
    class AnalizadorLexico
    {
        private LinkedList<Token> Saida;
        private int estado;
        private String Auxlex;

        public LinkedList<Token> escanear (String entrada){

            entrada = entrada + "#";
            Saida = new LinkedList<Token>();
            estado = 0;
            Auxlex="";
            char c;
            for (int i = 0; i <= entrada.Length - 1; i++)
            {
                c = entrada.ElementAt(i);
                switch (estado) 
                {
                    case 0:
                        if (char.IsDigit(c)) {
                            estado = 1;
                            Auxlex += c;
                        } else if (c.CompareTo('+') == 0)
                        {

                            Auxlex += c;
                            agregarToken(Token.Tipo.OPERADOR_SOMA);

                        }
                        else if (c.CompareTo('-') == 0)
                        {

                            Auxlex += c;
                            agregarToken(Token.Tipo.OPERADOR_SUBTRACAO);

                        }
                        else if (c.CompareTo('*') == 0)
                        {

                            Auxlex += c;
                            agregarToken(Token.Tipo.OPERADOR_MULTIPLICACAO);

                        }
                        else if (c.CompareTo('%') == 0)
                        {

                            Auxlex += c;
                            agregarToken(Token.Tipo.OPERADOR_DIVISAO);

                        }
                        else if (c.CompareTo('(') == 0)
                        {

                            Auxlex += c;
                            agregarToken(Token.Tipo.PONTUACAO_PARENTESES_ESQUERDO);

                        }
                        else if (c.CompareTo(')') == 0)
                        {

                            Auxlex += c;
                            agregarToken(Token.Tipo.PONTUACAO_PARENTESES_DIREITO);

                        }
                        else 
                        {
                            if (c.CompareTo('#') == 0 && i == entrada.Length - 1)
                            {
                                Console.WriteLine("Análise concluída com exito");

                            }
                            else 
                            {
                                Console.WriteLine("Erro léxico em: " + c);
                                estado = 0;
                            }



                        }


                        break;
                    case 1:
                        if (char.IsDigit(c))
                        {
                            estado = 1;
                            Auxlex += c;
                        }
                        else if (c.CompareTo('.') == 0)
                        {
                            estado = 2;
                            Auxlex += c;
                          


                        }
                        else {

                            agregarToken(Token.Tipo.NUMERO_INTEIRO);
                            i -= 1;


                        }
                        break;
                    case 2:
                        if (Char.IsDigit(c))
                        {
                            estado = 3;
                            Auxlex += c;
                        }
                        else
                        {
                            Console.WriteLine("Erro léxico em: " + c  );
                            estado = 0;
                        }
                        break;

                }

            }



            return Saida;
        }

        public void agregarToken(Token.Tipo tipo) {

            Saida.AddLast(new Token(tipo, Auxlex));
            Auxlex = "";
            estado = 0;
        
        }
        public void imprimirListaToken(LinkedList<Token> lista) 
        {
            foreach (Token item in lista) 
            {
                Console.WriteLine(item.GetTipo() + "" + item.Getval());
            }
        }

    }
}
