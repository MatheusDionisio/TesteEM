using System;

namespace Aluno
{
    public enum EnumeradorSexo
    {
        Masculino=0,
        Feminino=1
    }
    public class Aluno
    {
        private int matricula;
        private int Matricula
        {
            get { return matricula; }
            set {
                if (Convert.ToString(value).Length > 9 || Convert.ToString(value).Length == 0)
                    throw new FormatException();
                matricula = value;
            }
        }
        private string nome;
        private string Nome
        {
            get { return nome; }
            set 
            {
                if (value.Length > 100 || value.Length <= 0)
                    throw new FormatException();
                nome = value;
            }
        }
        private string cpf;
        private string Cpf
        {
            get { return cpf; }
            set
            {
                cpf = value;
            }
        }
        private DateTime nascimento;
        private DateTime Nascimento
        {
            get { return nascimento; }
            set
            {
                nascimento = value;
            }
        }
        private EnumeradorSexo sexo;
        private EnumeradorSexo Sexo
        {
            get { return sexo; }
            set
            {
                sexo = value;
            }
        }
        public Aluno(int matriculaIn, string nomeIn, string cpfIn, DateTime nascimentoIn,EnumeradorSexo sexoIn)
        {
            Matricula = matriculaIn;
            Nome = nomeIn;
            Cpf = cpfIn;
            Nascimento = nascimentoIn;
            Sexo = sexoIn;

        }
        public override string ToString()
        {
            return $"Aluno\nMatricula: {matricula}\nNome: {nome}\nCPF: {cpf}\nNascimento{nascimento}\nSexo: {sexo}";
        }
        public override bool Equals(object obj)
        {
            return obj is Aluno aluno && aluno.matricula == matricula;
        }
        public string showSexo()
        {
            return Convert.ToString(matricula);
        }
<<<<<<< HEAD
        public bool AlunoEhTop()
        {
            return nome.Equals("Matheus");
=======
        public bool AlunoEhLindo()
        {
            return nome.Equals("Rafael");
>>>>>>> 2623b3a87c13a1ad90b0d4f2b3149490a7ea773d
        }
    }
}
