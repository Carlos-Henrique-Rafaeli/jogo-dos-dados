
# Jogo Dos Dados

## Demonstração

![](https://i.imgur.com/0mgouLf.gif)

## Introdução

Um jogo onde você compete com o computador jogando dados. Quem chegar primeiro ao final é o vencedor.

## Funcionalidades

- **Jogada de Dados**: A cada rodada, o jogador e o computador jogam um dado. O valor sorteado é somado à posição de cada um.
- **Eventos especiais**: Existem alguns eventos especiais, eles são:
	- **Avanço de casas**: As casas 5, 10, 15 e 25 avançam 3 casas.
	- **Recuo de casas**: As casas 7, 13 e 20 voltam 2 casas.
	- **Rodada bônus**: Caso o o valor do dado jogado for igual a 6, será concedido uma rodada extra.
- **Feedback**: O jogo mostra a posição atual dos dois jogadores a cada rodada, e caso tenha um evento, o mesmo será mostrado também.
- **Reinício de Partida**: Ao fim da partida, é possível reiniciar e jogar novamente.

## Como utilizar

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto.

```
dotnet restore
```

4. Em seguida, compile a solução utilizando o comando:
   
```
dotnet build --configuration Release
```

5. Para executar o projeto compilando em tempo real
   
```
dotnet run --project JogoDosDados.ConsoleApp
```

6. Para executar o arquivo compilado, navegue até a pasta `./JogoDosDados.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:
   
```
JogoDosDados.ConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
