namespace CartaoApi.Models
{
    public class CartaoCredito
    {
        [key]
        public int Id {get; set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres"])
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres"])

        [key]
        public int IdCliente {get; set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres"])
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres"])

        public int NumeroCartao {get; set;}
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(16, ErrorMessage = "O Cartao deve conter no maximo 16 numeros")]
        [Range(1, int.MaxValue, ErrorMessage = "O Numero deve ser maior que 0")]
    }
}