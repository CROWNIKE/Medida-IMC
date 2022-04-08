namespace Pessoa.console
{
    internal class Pessoa
    {
        //Atributos
        public double peso, altura;

        //Cálculo
        public double calculo()
        {
            return peso / (altura * altura);

        }

        //Situacao

        public string Situacao(double imc)
        {
            //Variavel
            string retorno;

            //Condicional
            if (imc < 18.5)
            {
                retorno = "Abaixo do peso";

            }
            else if (imc < 25)
            {
                retorno = "Peso normal";
            }
            else if (imc < 30)
            {
                retorno = "Acima do peso";
            }
            else if (imc < 35)
            {
                retorno = "Obesidade 1";
            }
            else if (imc < 40)
            {
                retorno = "Obesidade 2";
            }
            else
            {
                retorno = "Obesidade 3";
            }
            //Retorno
            return retorno;
        }
    }
    //Mensagem
    public void Mensagem()
    {
        //Obter o calculo
        double obterCalculo = Calculo();

        //Obter situacao
        string obterSituacao = Situacao(obterCalculo);

        //Exibir 
    }
}
