Algoritmo "Calculadordemedia"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 11/03/2025
Var
// Seção de Declarações das variáveis 
   soma,idade,cont:inteiro
   media:real
Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
    escreval("digite as idades")
    leia(idade)
    soma<- 0
    cont<- 0
    enquanto idade >=0 faca
    soma <- soma + idade
    cont<-cont + 1
    leia(idade)
    fimenquanto
    se cont = 0 entao
    escreval("impossivel de calcular")
                         senao
                         media<-soma/cont
                         escreval(media:4:2)
    fimse
Fimalgoritmo