namespace Exercicio_de_orientacao_a_objetos_1
{
    public class Receita
    {    
        public Receita(string nome = "") // construtor da classe // "" mantem vazio e usa o valor padrao
        {
             this.Nome = Nome;
        }

       // public Receita(){} // apos criar o vazio os erros sumiram// metodo agregado//construtor de metodos
       // mas se usar no construtor acima o  (string nome = "")  como "" o segundo nao e necessario
        

        
        public string tamanho { get; set; } // sempre publico para usar no program.cs 

        public  decimal peso { get; set; }

        public  decimal preco { get; set; }

        public string Nome { get; set; }

        private void Salvar() // funcao 
        {
           
        }

        private void Mostrar()
        {
             
        }
    }
}