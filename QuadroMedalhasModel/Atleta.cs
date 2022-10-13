namespace QuadroMedalhasDomain
{
    public class Atleta : Entity
    {
        public int codigo { get; set; }
        public string siglaPais { get; set; }
        public Medalha medalhas { get; set; }
    }
}
