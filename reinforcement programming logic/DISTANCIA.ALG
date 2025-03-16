Algoritmo "distancia"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 07/03/2025
Var
// Seção de Declarações das variáveis 
   d1,d2,d3, maior : real

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
   escreval("escreva o valor dos tres valores")
     leia(d1)
     leia(d2)
     leia(d3)
     
     se (d1>d2) e (d1>d3) entao
     escreval("o valor de d1")
     senao
        se(d2>d1) e (d2>d3)entao
           escreval("o valor de d2")
           senao
           escreval("o valor de d3")
        fimse
     fimse
Fimalgoritmo
