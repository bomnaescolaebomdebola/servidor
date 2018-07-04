using System.Collections.Generic;


namespace Model.Aluno
{
    public class Aluno : Mongo.MongoID
    {
        public string nome { get; set; }
        public string dataNasc { get; set; }
        public string escola { get; set; }
        public string serie { get; set; }
        public string responsavel {get;set;}
        public  List<string> telefones {get;set;}

        public byte[] foto {get;set;}
        

    }
}