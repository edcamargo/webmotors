namespace WebMotors.Domain.Entities
{
    public class AnnouncementWebmotors
    {
        /*
        public AnnouncementWebmotors(int id, 
                                     string marca, 
                                     string modelo, 
                                     string versao, 
                                     int ano, 
                                     int quilometragem, 
                                     string observacao)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Versao = versao;
            Ano = ano;
            Quilometragem = quilometragem;
            Observacao = observacao;
        }
        */

        public int Id { get; set; }
        public string? Marca { get; set; }
        public string? Modelo {  get; set; }
        public string? Versao {  get; set; }
        public int Ano { get; set; }
        public int Quilometragem { get; set; }
        public string? Observacao { get; set; }
    }
}