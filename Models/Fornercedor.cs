namespace LHPet.Models;

public class Fornecedor{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cpnj { get; set; }
    public string Email { get; set; }
    

    public Fornecedor(int id, string nome, string cpnj, string email)
    {
      this.Id= id;
      this.Nome= nome;
      this.Cpnj= cpnj;
      this.Email= email;
      
    }

};