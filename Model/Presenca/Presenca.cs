using System.Collections.Generic;

namespace Model.Presenca
{
    public class Presenca : Mongo.MongoID
    {
        public Aluno.Aluno aluno { get; set; }
        public bool presente { get; set; }

    }
}