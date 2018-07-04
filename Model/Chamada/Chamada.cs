using System;
using System.Collections.Generic;

namespace Model.Chamada
{
    public class Chamada : Mongo.MongoID
    {
        public Treino.Treino treino { get; set; }
        public DateTime dataChamada {get;set;}
        public DateTime dataEnvio {get;set;}
        public List<Presenca.Presenca> presencas { get; set; }

    }
}