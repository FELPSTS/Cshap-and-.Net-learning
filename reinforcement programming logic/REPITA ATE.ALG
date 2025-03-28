Algoritmo "Repita ate"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 27/03/2025
Var
// Seção de Declarações das variáveis 
   C,F : real
   resp:caracter

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
   repita
         escreva("digite a temperatura em Celsius: ")
         leia(C)
         F <-9.0*C/5.0+32.0
         escreval("Equivalente em Fahrenheit ",F:3:1)
         escreva("Desaja repitir  s/n?")
         leia(resp)
         ate resp <> "s"

Fimalgoritmo