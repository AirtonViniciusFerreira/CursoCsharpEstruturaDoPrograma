namespace EstruturaDoPrograma.Exemplos
{
    public class Pilha
    {
        Posicao primeiro;

        public void empilhar(object item)
        {
            this.primeiro = new Posicao(this.primeiro, item);
        }

        public object desempilhar()
        {
            if (this.primeiro == null)
            {
                throw new System.InvalidOperationException("A pilha está vazia!");
            }

            object resultado = this.primeiro.item;
            this.primeiro = this.primeiro.proximo;
            return resultado;
        }


        class Posicao
        {
            public Posicao proximo;

            public object item;

            public Posicao(Posicao proximo, object item)
            {
                this.proximo = proximo;
                this.item = item;
            }

        }
    }
}