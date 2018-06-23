namespace Model.Voluntario
{
    public class Voluntario : Mongo.MongoID
    {
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string email { get; set; }

    }
}