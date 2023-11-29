# AutenticacaoDeDoisFatores

## Descrição do Projeto

Este projeto utiliza a ASP.NET Web API para criar uma API responsável por gerenciar a autenticação de usuários por meio de dois fatores. O primeiro fator é o cadastro convencional, e o segundo é a autenticação via QR Code. A intenção é proporcionar uma camada adicional de segurança, permitindo o login apenas para usuários autenticados por ambos os fatores.

## Funcionalidades

- **Cadastro de Usuário**: Permite o registro convencional de usuários na plataforma.
- **Autenticação por QR Code**: Utiliza um sistema de autenticação de dois fatores, onde o segundo fator é verificado por meio de QR Code.
- **Controle de Acesso**: O acesso à plataforma é concedido somente após a autenticação bem-sucedida por ambos os fatores.

## Tecnologias Utilizadas

- **ASP.NET Web API**: Framework para construir APIs HTTP em .NET.
- **C#**: Linguagem de programação utilizada no desenvolvimento do backend.
- **Entity Framework (ou seu ORM de escolha)**: Para interagir com o banco de dados.
- **Biblioteca para geração e leitura de QR Code**: Utilizada para gerar e verificar QR Codes.

## Configuração e Uso

1. Clone o repositório: `git clone https://github.com/jfmartinsvred1/AutenticacaoDeDoisFatores`
2. Abra a solução no Visual Studio.
3. Configure o banco de dados e outras variáveis de ambiente conforme necessário.
4. Execute o projeto.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou pull requests.

## Licença

Este projeto está licenciado sob a Licença MIT - veja o arquivo [LICENSE.md](LICENSE.md) para detalhes.