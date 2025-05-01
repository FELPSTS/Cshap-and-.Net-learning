Algoritmo "divisao"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 30/04/2025
Var
// Seção de Declarações das variáveis 
 N,i:inteiro
 x,y,divisao :real

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
  escreva("quantos numeros voce vai digitar?")
  leia(N)
  
  para i de 1 ate N faca

  escreva("Entre com o numerador: ")
  leia(x)
  escreva("Entre com o denominador: ")
  leia(y)
  
  se y = 0 entao
  escreval("IMPOSSIVEL")
  senao
  divisao<- x/y
  escreval("DIVISAO=",divisao:4:2)
  fimse

  fimpara

Fimalgoritmo