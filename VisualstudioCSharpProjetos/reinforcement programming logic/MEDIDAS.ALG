Algoritmo "medidas"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 21/02/2025
Var
// Seção de Declarações das variáveis 
    A,B,C:real
    quadrado,traingulo,trapezio:real

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
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