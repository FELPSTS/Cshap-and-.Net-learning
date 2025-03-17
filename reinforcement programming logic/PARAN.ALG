Algoritmo "paraN"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 16/03/2025
Var
// Seção de Declarações das variáveis 
   n,i,soma,x :inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
       escreval("quantos numeors")
       leia(n)
       
       soma <- 0
       
       para i de 1 ate n faca
            escreva("digite um numero: ")
            leia(x)
            soma<- soma + x
       fimpara
       escreva("soma = ",soma)

Fimalgoritmo