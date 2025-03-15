Algoritmo "semnome"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 18/08/2024
Var
Base      :real
Altura    :real
Diagonal  :real
Area      :real
perimetro :real

Inicio
   escreva("Base do retangulo: ")
   leia(Base)
   escreva("Altura do retangulo: ")
   leia(Altura)
   Area <- Base * Altura
   escrevaL("Area:",Area:8:4)
   perimetro <- exp(Base,2)+exp(Altura,2)
   escrevaL("perimetro: ",perimetro:8:4)
   Diagonal <- RaizQ(exp(Base,2)+exp(altura,2))
   escrevaL("Diagonal: ",Diagonal:             8:4)
Fimalgoritmo