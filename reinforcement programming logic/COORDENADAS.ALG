Algoritmo "coordenadas"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 07/03/2025
Var
// Seção de Declarações das variáveis 
    x,y:real

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
     escreval("valor de x: ")
     leia(x)
     escreval("valor de y: ")
     leia(y)
     
     se (x>0)e(y>0)entao
     escreval("q1")
     senao
          se(x<0)e(y>0)entao
          escreval("q2")
          senao
                       se(x<0)e (y<0)entao
                       escreval(q3)
                       senao
                       se(x>0)e(y<0)entao
                       escreval("q4")
                       senao
                                     se(x=0)e(y=0)entao
                                     escreva("origem")
                                     senao
                                                      se x=0 entao
                                                      escreval("eixo Y")
                                                      senao
                                                         escreval("eixoX")
                                                         fimse
                                                      fimse
                                     fimse
                       fimse
          fimse
     fimse
                       
Fimalgoritmo



