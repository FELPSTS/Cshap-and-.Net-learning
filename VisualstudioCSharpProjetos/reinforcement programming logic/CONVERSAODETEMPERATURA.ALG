Algoritmo "Conversaodetemp"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 07/03/2025
Var
// Seção de Declarações das variáveis 
   unidade   :  caracter
   FN,CN :  real

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
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