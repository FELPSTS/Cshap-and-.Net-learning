Algoritmo "Conversaodetemp"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 07/03/2025
Var
// Se��o de Declara��es das vari�veis 
   unidade   :  caracter
   FN,CN :  real

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
    escreval("digite para qual medida sera convertida")
    leia(unidade)
    
    se unidade = "F" entao
       escreval("digite o valor em FN")
       leia(FN)
       CN <- 5/9 *(FN-32)
       escreval(CN 4:2)
                   senao
                      se unidade = "C" entao
                      escrevaL("digite o valor em C")
                      leia(CN)
                         FN <- 9 * CN / 5 + 32
                         escreval(FN:4:2)
                   fimse
    fimse

Fimalgoritmo