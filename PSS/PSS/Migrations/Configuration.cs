namespace PSS.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using PSS.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<SGCO.Context.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SGCO.Context.Context context)
        {
            context.States.AddOrUpdate(p => p.Id,
                new State { UF = "AC", IsActive = true, Name = "Acre" },
                new State { UF = "AL", IsActive = true, Name = "Alagoas" },
                new State { UF = "AP", IsActive = true, Name = "Amap�" },
                new State { UF = "AM", IsActive = true, Name = "Amazonas" },
                new State { UF = "BA", IsActive = true, Name = "Bahia" },
                new State { UF = "CE", IsActive = true, Name = "Cear�" },
                new State { UF = "DF", IsActive = true, Name = "Distrito Federal" },
                new State { UF = "ES", IsActive = true, Name = "Esp�rito Santo" },
                new State { UF = "GO", IsActive = true, Name = "Goi�s" },
                new State { UF = "MA", IsActive = true, Name = "Maranh�o" },
                new State { UF = "MT", IsActive = true, Name = "Mato Grosso" },
                new State { UF = "MS", IsActive = true, Name = "Mato Grosso do Sul" },
                new State { UF = "MG", IsActive = true, Name = "Minas Gerais" },
                new State { UF = "PA", IsActive = true, Name = "Par�" },
                new State { UF = "PB", IsActive = true, Name = "Para�ba" },
                new State { UF = "PR", IsActive = true, Name = "Paran�" },
                new State { UF = "PE", IsActive = true, Name = "Pernambuco" },
                new State { UF = "PI", IsActive = true, Name = "Piau�" },
                new State { UF = "RJ", IsActive = true, Name = "Rio de Janeiro" },
                new State { UF = "RN", IsActive = true, Name = "Rio Grande do Norte" },
                new State { UF = "RS", IsActive = true, Name = "Rio Grande do Sul" },
                new State { UF = "RO", IsActive = true, Name = "Rond�nia" },
                new State { UF = "RR", IsActive = true, Name = "Roraima" },
                new State { UF = "SC", IsActive = true, Name = "Santa Catarina" },
                new State { UF = "SP", IsActive = true, Name = "S�o Paulo" },
                new State { UF = "SE", IsActive = true, Name = "Sergipe" },
                new State { UF = "TO", IsActive = true, Name = "Tocantins" });

            context.Genders.AddOrUpdate(p => p.Id,
                new Gender { Description = "Homem", IsActive = true },
                new Gender { Description = "Mulher", IsActive = true },
                new Gender { Description = "Indefinido", IsActive = true });

            context.UserTypes.AddOrUpdate(p => p.Id,
                new UserType { Description = "Administrador", IsActive = true },
                new UserType { Description = "Cliente", IsActive = true },
                new UserType { Description = "Visitante", IsActive = true });
        }
    }
}
