Algoritmo "tempodeJogo"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 07/03/2025
Var
// Seção de Declarações das variáveis
horainicial,horafinal,duracao:inteiro


Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
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