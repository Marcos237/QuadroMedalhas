namespace QuadroMedalhasRepository.DTO
{
    public class QuadroMedalhaDTO
    {
        public Guid id { get; set; }
        public string pais { get; set; }
        public List<MedalhaDTO> medalhas { get; set; }
    }
}
