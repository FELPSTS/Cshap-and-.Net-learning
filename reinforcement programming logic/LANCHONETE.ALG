Algoritmo "LANCHONETE"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 07/03/2025
Var
// Se��o de Declara��es das vari�veis 
   codigo,quantidade:inteiro
   valorPago:real
         

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
     escreval("digite o numero de  1 a 5")
     leia(codigo)
     escreval("digite a quantidade comprada")
     leia(quantidade)

     escolha codigo
        caso 1
        valorPago <- 5.0 * quantidade
        caso 2
        valorPago <- 3.5 * quantidade
        caso 3
        valorPago <- 4.8 * quantidade
        caso 4
        valorPago <- 8.9 * quantidade
        caso 5
        valorPago <- 7.32 * quantidade
     fimescolha
        escrevaL("o valor final a ser pago sera de RS:",valorPago:4:2)
Fimalgoritmo