namespace SGCO.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using SGCO.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<SGCO.Context.Contexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "SGCO.Context.Contexto";
        }

        protected override void Seed(SGCO.Context.Contexto context)
        {
            context.Estados.AddOrUpdate(x => x.UF,
                    new Estado() { UF = "AC", Nome = "Acre" },
                    new Estado() { UF = "AL", Nome = "Alagoas" },
                    new Estado() { UF = "AP", Nome = "Amapá" },
                    new Estado() { UF = "AM", Nome = "Amazonas" },
                    new Estado() { UF = "BA", Nome = "Bahia" },
                    new Estado() { UF = "CE", Nome = "Ceará" },
                    new Estado() { UF = "DF", Nome = "Distrito Federal" },
                    new Estado() { UF = "ES", Nome = "Espírito Santo" },
                    new Estado() { UF = "GO", Nome = "Goiás" },
                    new Estado() { UF = "MA", Nome = "Maranhão" },
                    new Estado() { UF = "MT", Nome = "Mato Grosso" },
                    new Estado() { UF = "MS", Nome = "Mato Grosso do Sul" },
                    new Estado() { UF = "MG", Nome = "Minas Gerais" },
                    new Estado() { UF = "PA", Nome = "Pará" },
                    new Estado() { UF = "PB", Nome = "Paraíba" },
                    new Estado() { UF = "PR", Nome = "Paraná" },
                    new Estado() { UF = "PE", Nome = "Pernambuco" },
                    new Estado() { UF = "PI", Nome = "Piauí" },
                    new Estado() { UF = "RJ", Nome = "Rio de Janeiro" },
                    new Estado() { UF = "RN", Nome = "Rio Grande do Norte" },
                    new Estado() { UF = "RS", Nome = "Rio Grande do Sul" },
                    new Estado() { UF = "RO", Nome = "Rondônia" },
                    new Estado() { UF = "RR", Nome = "Roraima" },
                    new Estado() { UF = "SC", Nome = "Santa Catarina" },
                    new Estado() { UF = "SP", Nome = "São Paulo" },
                    new Estado() { UF = "SE", Nome = "Sergipe" },
                    new Estado() { UF = "TO", Nome = "Tocantins " });
        }
    }
}
