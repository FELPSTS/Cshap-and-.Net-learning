Algoritmo "soma_impares"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 21/03/2025
Var
// Se��o de Declara��es das vari�veis 
    x,y,i,troca,soma:inteiro

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
    escrevaL("digite dois numeros")
    leia(x)
    leia(y)

    se x > y entao
         x<-y
         y<-troca
    fimse
    
       soma <- 0
       para i de x +1 ate y -1 faca
       se i % 2 <>  0 entao
       soma <- soma + i
       fimse
    fimpara
    
    escreva("Soma dos impares =",soma)
Fimalgoritmo
