Algoritmo "dentro_fora"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 30/04/2025
Var
// Se��o de Declara��es das vari�veis 
   N,x,i,dentro,fora:inteiro

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
   dentro<-0
   fora<-0
   
   escreva("Quantos numeros voce vai digitar?")
   leia(N)
   
   para i de 1 ate N faca
   
   escreva("Digite um numero:")
   leia(x)
   
   se(x>=10)e(x=10)entao
   dentro <- dentro + 1
   senao
   fora<-fora + 1
   fimse
   fimpara
   escreval (dentro,"DENTRO")
   escreval (fora,"FORA")

Fimalgoritmo