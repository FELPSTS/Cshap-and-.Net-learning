Algoritmo "aumentodesalrio"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 07/03/2025
Var
// Se��o de Declara��es das vari�veis
   salario,aumento,novosalario :real
   porcentagem:inteiro


Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
    escreval("digite o salario da pessoa")
    leia(salario)
    
    se (salario <= 1000.00) entao
    porcentagem <- 20
                senao
                se(salario <= 3000)entao
                porcentagem <-15
                            senao
                            se salario <= 8000 entao
                            porcentagem<-10
                                           senao
                                           porcentagem <- 5
                            fimse
                fimse
    fimse
    
    aumento <- salario * porcentagem / 100
    
    novosalario <- aumento + salario
    
    escreval ("porcentagem: " , porcentagem)
    
    escreval("o salario novo ser� de: " , novosalario)

    escreval("aumento: " , aumento)


Fimalgoritmo
