# myfinance-web-dotnet-o8
Sistema de finanças pessoais - Projeto do curso de pós-graduação PUC Minas

# 🧾 Descrição do Projeto

Este sistema tem como objetivo auxiliar famílias no controle financeiro pessoal por meio do registro e categorização de receitas e despesas. Com base em um **Plano de Contas** personalizado, os usuários podem registrar transações e analisar suas finanças por meio de **relatórios detalhados** e **gráficos interativos**, promovendo assim um melhor planejamento financeiro.

# 🛠️ Funcionalidades principais

- Cadastro de Plano de Contas (Receitas e Despesas)
- Registro de Transações financeiras vinculadas ao Plano de Contas
- Relatórios HTML por período e tipo de transação
- Gráfico de Pizza comparando Receitas e Despesas por período

# 🏛️ Arquitetura Utilizada

A aplicação foi desenvolvida utilizando a arquitetura **MVC (Model-View-Controller)** com separação clara entre responsabilidades, permitindo fácil manutenção e escalabilidade.

- **Modelos (Models):** Representações das entidades do sistema como Plano de Contas, Transações, etc.
- **Controladores (Controllers):** Gerenciam a lógica do negócio e o fluxo entre as views e os modelos.
- **Visões (Views):** Páginas HTML, responsáveis pela interação com o usuário.
- **Repositórios (Repositories):** Camada de acesso a dados com Entity Framework.
- **Serviços (Services):** Camada para encapsular regras de negócio.

# 💻 Tecnologias Utilizadas

| Tecnologia | Finalidade |
|------------|------------|
| [.NET 8](https://dotnet.microsoft.com/en-us/) | Framework principal para backend |
| ASP.NET Core MVC | Estrutura web baseada em MVC |
| Entity Framework Core | ORM para acesso ao banco de dados |
| MySQL Server | Banco de dados (dependendo do ambiente) |
| Bootstrap | Estilização das interfaces (opcional) |

# ⚙️ Como configurar o projeto

**Pré-requisitos**

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- Editor de código como [Visual Studio 2022+](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/)
- [MySQL] (https://www.mysql.com/)


# 📈 Funcionalidades futuras (Backlog)
Exportação de relatórios para PDF
Autenticação de usuários
Dashboard com KPIs
Compartilhamento de acesso entre membros da família