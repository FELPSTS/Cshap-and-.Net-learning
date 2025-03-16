Algoritmo "bhaskara"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 24/02/2025
Var
   // Seção de Declarações das variáveis
   a, b, c, x1, x2, delta: real

Inicio
   // Seção de Comandos, procedimento, funções, operadores, etc...
   escreval("Digite o valor de A:")
   leia(a)
   escreval("Digite o valor de B:")
   leia(b)
   escreval("Digite o valor de C:")
   leia(c)

   // Cálculo do delta
   delta <- (b * b) - (4 * a * c)

   // Verificação se há raízes reais
   se (a = 0) ou (delta < 0) então
       escreval("ESTE X NÃO POSSUI RAIZ")
   senao
       x1 <- (-b + raizQ(delta)) / (2 * a)
       x2 <- (-b - raizQ(delta)) / (2 * a)
       escreval("X1: ", x1)
       escreval("X2: ", x2)
   fimse

Fimalgoritmo