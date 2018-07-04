using System;
using System.Collections.Generic;


namespace Model.Treino
{
    public class Treino : Mongo.MongoID
    {
        public List<Aluno.Aluno> alunos { get; set; }
        public List<Voluntario.Voluntario> voluntario { get; set; }
        public DateTime horario { get; set; }
        public string diaSemana { get; set; }
        public string responsavel {get;set;}
        public  List<string> telefones {get;set;}

        public byte[] foto {get;set;}
        

    }
}