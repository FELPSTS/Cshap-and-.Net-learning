Algoritmo "Calculadordemedia"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 11/03/2025
Var
// Se��o de Declara��es das vari�veis 
   soma,idade,cont:inteiro
   media:real
Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
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