Algoritmo "tempodeJogo"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 07/03/2025
Var
// Se��o de Declara��es das vari�veis
horainicial,horafinal,duracao:inteiro


Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
    escreval("horainicial")
    leia(horainicial)
    escreval("horafinal")
    leia(horafinal)

    se horainicial < horafinal entao
       duracao <- horafinal - horainicial
    senao
       duracao <- 24 - horainicial + horafinal
    fimse
    
    escreval("O jogo durou", duracao ,"Horas")

Fimalgoritmo