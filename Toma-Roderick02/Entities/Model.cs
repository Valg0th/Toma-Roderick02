namespace Toma_Roderick02.Entities
{
    abstract public class Model
    {
        public string Id { get; set; }
        public Model(string id)
        {
            Id = id;
        }
    }
}
