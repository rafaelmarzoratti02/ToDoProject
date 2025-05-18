using System;

namespace ToDo.Core.Entities;

    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } 
        public bool Ativo { get; set; }
    

    public void Desativar()
    {
        Ativo = false;
    }

    protected BaseEntity()
    {
        Ativo = true;
        CreatedAt = DateTime.UtcNow;
    }
}