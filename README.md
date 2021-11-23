# Church

## Autor do projeto: Ricardo Alves Kindermann Junior.

## Descrição do projeto:

- Este projeto (inicialmente) tem como intuito, criar um programa para cadastro de membros de uma igreja.

Os dados necessários são:
- Todos os dados pessoais dos usuários (endereço, telefone, etc...).
- Dados do veículo do usuários da igreja: caso precise localizar o dono do veículo, ficará mais fácil.
- Cargo que o usuário ocupa dentro da igreja.
- Cadastro de cargos (diácono, pastor, etc...), indicando a função de cada cargo; além do mais, precisará configurar a permissão de cada cargo: (qual cargo que poderá ver a lista de membros, etc...)

## Features futuras:

- No futuro será criado uma feature, para que os usuários possam se comunicar com os obreiros da igreja, solicitando algo durante o culto. 
Por exemplo: um membro quer tomar água, pedir um envelope, etc... Ele digitará no app o que deseja e um obreiro pode auxiliar aquele membro.
- Sistema de contabilidade: entrada e saída de valores (R$).

## Linguagem utilizada:

C# (Versão .NET 3.1)

## Banco de dados:

Este programa faz a conexão com banco de dados MySql, com isso utilizei a biblioteca MySql.Data.MySqlClient.

## APIs para busca de endereço:

Utilizei a API https://viacep.com.br , para busca do endereço, utilizando o CEP como parâmetro.

## Features (Roadmap):

- [ ] Cadastro de igreja;
- [ ] Cadastro de usuário;
- [ ] Cadastro de carro;
- [ ] Cadastro de cargo;
- [ ] Login no app;
- [ ] Funcionalidade para que o usuário se comunique com os obreiros, durante o culto;
- [ ] Módulo de contabilidade;
