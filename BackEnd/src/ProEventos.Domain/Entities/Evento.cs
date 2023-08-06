
namespace ProEventos.Domain.Entities;

public class Evento
{
    public int EventoId { get; set; } 
    public string EventoName { get; set;}
    public string EventoDescription { get; set;}
    public DateTime EventoDate { get; set; }
    public string Tema { get; set;}
    public int QtdPessoas { get; set; }
    public string Lote { get; set; }
    public string ImagemURL { get; set; }
}
