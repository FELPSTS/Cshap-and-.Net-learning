Algoritmo "distancia"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 07/03/2025
Var
// Se��o de Declara��es das vari�veis 
   d1,d2,d3, maior : real

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
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
