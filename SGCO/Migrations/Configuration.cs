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
            AutomaticMigrationsEnabled = false;
            ContextKey = "SGCO.Context.Contexto";
        }

        protected override void Seed(SGCO.Context.Contexto context)
        {
            context.Estados.AddOrUpdate(x => x.UF,
                    new Estado() { UF = "AC", Nome = "Acre" },
                    new Estado() { UF = "AL", Nome = "Alagoas" },
                    new Estado() { UF = "AP", Nome = "Amap�" },
                    new Estado() { UF = "AM", Nome = "Amazonas" },
                    new Estado() { UF = "BA", Nome = "Bahia" },
                    new Estado() { UF = "CE", Nome = "Cear�" },
                    new Estado() { UF = "DF", Nome = "Distrito Federal" },
                    new Estado() { UF = "ES", Nome = "Esp�rito Santo" },
                    new Estado() { UF = "GO", Nome = "Goi�s" },
                    new Estado() { UF = "MA", Nome = "Maranh�o" },
                    new Estado() { UF = "MT", Nome = "Mato Grosso" },
                    new Estado() { UF = "MS", Nome = "Mato Grosso do Sul" },
                    new Estado() { UF = "MG", Nome = "Minas Gerais" },
                    new Estado() { UF = "PA", Nome = "Par�" },
                    new Estado() { UF = "PB", Nome = "Para�ba" },
                    new Estado() { UF = "PR", Nome = "Paran�" },
                    new Estado() { UF = "PE", Nome = "Pernambuco" },
                    new Estado() { UF = "PI", Nome = "Piau�" },
                    new Estado() { UF = "RJ", Nome = "Rio de Janeiro" },
                    new Estado() { UF = "RN", Nome = "Rio Grande do Norte" },
                    new Estado() { UF = "RS", Nome = "Rio Grande do Sul" },
                    new Estado() { UF = "RO", Nome = "Rond�nia" },
                    new Estado() { UF = "RR", Nome = "Roraima" },
                    new Estado() { UF = "SC", Nome = "Santa Catarina" },
                    new Estado() { UF = "SP", Nome = "S�o Paulo" },
                    new Estado() { UF = "SE", Nome = "Sergipe" },
                    new Estado() { UF = "TO", Nome = "Tocantins " }
            );
        }
    }
}
