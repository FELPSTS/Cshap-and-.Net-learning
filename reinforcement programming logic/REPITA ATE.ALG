Algoritmo "Repita ate"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 27/03/2025
Var
// Se��o de Declara��es das vari�veis 
   C,F : real
   resp:caracter

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
   repita
         escreva("digite a temperatura em Celsius: ")
         leia(C)
         F <-9.0*C/5.0+32.0
         escreval("Equivalente em Fahrenheit ",F:3:1)
         escreva("Desaja repitir  s/n?")
         leia(resp)
         ate resp <> "s"

Fimalgoritmo