Algoritmo "operador"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 06/03/2025
Var
// Se��o de Declara��es das vari�veis 
   minutos:inteiro
   valorPago:real
Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
   escreva("Digite a quantidade de minutos:")
   leia(minutos)
   
   valorPago<-50.0
   se minutos > 100 entao
      valorPago <- valorPago + 2 *(minutos - 100)
   fimse
   
   escreval("valor a pagar:RS",valorPago:4:2)

Fimalgoritmo