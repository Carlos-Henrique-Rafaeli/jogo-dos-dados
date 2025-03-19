
# Jogo Dos Dados

## Demonstra��o

![](https://i.imgur.com/0mgouLf.gif)

## Introdu��o

Um jogo onde voc� compete com o computador jogando dados. Quem chegar primeiro ao final � o vencedor.

## Funcionalidades

- **Jogada de Dados**: A cada rodada, o jogador e o computador jogam um dado. O valor sorteado � somado � posi��o de cada um.
- **Eventos especiais**: Existem alguns eventos especiais, eles s�o:
	- **Avan�o de casas**: As casas 5, 10, 15 e 25 avan�am 3 casas.
	- **Recuo de casas**: As casas 7, 13 e 20 voltam 2 casas.
	- **Rodada b�nus**: Caso o o valor do dado jogado for igual a 6, ser� concedido uma rodada extra.
- **Feedback**: O jogo mostra a posi��o atual dos dois jogadores a cada rodada, e caso tenha um evento, o mesmo ser� mostrado tamb�m.
- **Rein�cio de Partida**: Ao fim da partida, � poss�vel reiniciar e jogar novamente.

## Como utilizar

1. Clone o reposit�rio ou baixe o c�digo fonte.
2. Abra o terminal ou o prompt de comando e navegue at� a pasta raiz
3. Utilize o comando abaixo para restaurar as depend�ncias do projeto.

```
dotnet restore
```

4. Em seguida, compile a solu��o utilizando o comando:
   
```
dotnet build --configuration Release
```

5. Para executar o projeto compilando em tempo real
   
```
dotnet run --project JogoDosDados.ConsoleApp
```

6. Para executar o arquivo compilado, navegue at� a pasta `./JogoDosDados.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:
   
```
JogoDosDados.ConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.
