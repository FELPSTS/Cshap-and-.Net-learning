Algoritmo "paraN"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 16/03/2025
Var
// Se��o de Declara��es das vari�veis 
   n,i,soma,x :inteiro

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
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