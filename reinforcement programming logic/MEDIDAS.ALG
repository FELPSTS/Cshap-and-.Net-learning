Algoritmo "medidas"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 21/02/2025
Var
// Se��o de Declara��es das vari�veis 
    A,B,C:real
    quadrado,traingulo,trapezio:real

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
   escreval("valor de A:")
   leia(A)
   escreval("valor de B:")
   leia(B)
   escreval("valor de C:")
   leia(C)
     quadrado<-A*A
     traingulo<-(A*B)/2
     trapezio<-((A+B)*C)/2
   escreval("os resultados seram: ")
   escreval("Area quadrado: ", quadrado:6:4)
   escreval("Area traingulo: ", traingulo:6:4)
   escreval("Area trapezio: ", trapezio:6:4)
Fimalgoritmo