# Polimorfismo

## Ó QUE É?

O polimorfismo costuma ser chamado de o terceiro pilar da programação orientada a objetos, depois do encapsulamento e a herança. O polimorfismo é uma palavra grega que significa "de muitas formas" e tem dois aspectos distintos: 

1. Em tempo de execução, os objetos de uma classe derivada podem ser tratados como objetos de uma classe base, em locais como parâmetros de método, coleções e matrizes. Quando isso ocorre, o tipo declarado do objeto não é mais idêntico ao seu tipo de tempo de execução.  

2. As classes base podem definir e aplicar métodos virtuais e as classes derivadas podem substituí-los, o que significa que elas fornecem sua própria definição e implementação. Em tempo de execução, quando o código do cliente chama o método, o CLR procura o tipo de tempo de execução do objeto e invoca a substituição do método virtual. Dessa forma, você pode chamar em seu código-fonte um método de uma classe base e fazer com que a versão de uma classe derivada do método seja executada.  

> Fonte : MSDN 

## A capacidade de tratar objetos criados a partir das classes específicas como objetos de uma classe genérica é chamada de POLIMORFISMO.

```c#
using System ;
class ControleDePonto
{
public void RegistraEntrada ( Gerente g )
{
DateTime agora = DateTime . Now ;
string horario = String . Format ( " {0: d / M / yyyy HH : mm : ss } " , agora ) ;
System . Console . WriteLine ( " ENTRADA : " + g . Codigo ) ;
System . Console . WriteLine ( " DATA : "
+ horario ) ;
}
public void RegistraSaida ( Gerente g )
{
DateTime agora = DateTime . Now ;
string horario = String . Format ( " {0: d / M / yyyy HH : mm : ss } " , agora ) ;
System . Console . WriteLine ( " SAÍDA : " + g . Codigo ) ;
System . Console . WriteLine ( " DATA : " + horario ) ;
}
}
```


```c#

using System ;

class ControleDePonto
{

    public void RegistraEntrada ( Funcionario f )

{

DateTime agora = DateTime . Now ;
string horario = String . Format ( " {0: d / M / yyyy HH : mm : ss } " , agora ) ;

System . Console . WriteLine ( " ENTRADA : " + f . Codigo ) ;

System . Console . WriteLine ( " DATA : "
+ horario ) ;

}

public void RegistraSaida ( Funcionario f )
{

DateTime agora = DateTime . Now ;

string horario = String . Format ( " {0: d / M / yyyy HH : mm : ss } " , agora ) ;

System . Console . WriteLine ( " SAÍDA : " + f . Codigo ) ;

System . Console . WriteLine ( " DATA : " + horario ) ;

 }
}
```
#### EXERCICIO





ESCREVA UM SOFTWARE DE BANDO COM INTENCAÇÃO PARA GERAR EXTRATO BANCÁRIO
UTILIANDO POLIMORFISMO ONDE O METODO ImprimirExtrato RECEBERÁ POR PARAMETROS 
TIPOS DE CONTAS DIFERENTES
