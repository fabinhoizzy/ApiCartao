using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CartaoApi.Models
{
    public class CartaoCredito
    {
        public int Id { get; set; }
        public string Email { get; set; }

        public void CriarCartao () //aqui vamos iniciar Criar Cartao vazio (void)
        {

        }

        public string GerandoNumero () //Criando o gerador de numero
        {
            Random random = new Random(); //ele vai ser um numero aleatorio por isso random
            string cartaoNumero = "";   //cartao Numero se iniciar vazio pra se preenchindo mais na frente
            int numeroAleatorio;

            for (int i = 0; i < 16; i++) // criando um numero < que 16 
            {
                numeroAleatorio = random.Next(1, 9); //serao numero entre 1 a 9
                cartaoNumero += numeroAleatorio.ToString(); //convertendo para num string
            }

            return cartaoNumero;
        }
        
    }
}
