Algoritmo "coordenadas"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 07/03/2025
Var
// Se��o de Declara��es das vari�veis 
    x,y:real

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
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



