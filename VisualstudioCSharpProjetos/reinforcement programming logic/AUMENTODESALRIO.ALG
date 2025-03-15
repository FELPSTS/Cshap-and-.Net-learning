Algoritmo "aumentodesalrio"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 07/03/2025
Var
// Seção de Declarações das variáveis
   salario,aumento,novosalario :real
   porcentagem:inteiro


Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
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
    
    escreval("o salario novo será de: " , novosalario)

    escreval("aumento: " , aumento)


Fimalgoritmo
